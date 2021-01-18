using NvAPIWrapper.Native;
using NvAPIWrapper.Native.Display.Structures;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tarkov_settings
{
    class GammaController
    {

        /*
         * Code from
         * https://github.com/falahati/NvAPIWrapper/issues/20#issuecomment-634551206
         */
        private ushort[] CalculateLUT(double brightness = 0.5, double contrast = 0.5, double gamma = 2.8)
        {
            const int dataPoints = 256;

            // Limit gamma in range [0.4-2.8]
            gamma = Math.Min(Math.Max(gamma, 0.4), 2.8);
            // Normalize contrast in range [-1,1]
            contrast = (Math.Min(Math.Max(contrast, 0), 1) - 0.5) * 2;
            // Normalize brightness in range [-1,1]
            brightness = (Math.Min(Math.Max(brightness, 0), 1) - 0.5) * 2;
            // Calculate curve offset resulted from contrast
            var offset = contrast > 0 ? contrast * -25.4 : contrast * -32;
            // Calculate the total range of curve
            var range = (dataPoints - 1) + offset * 2;
            // Add brightness to the curve offset
            offset += brightness * (range / 5);
            // Fill the gamma curve
            var result = new ushort[dataPoints];
            for (var i = 0; i < result.Length; i++)
            {
                var factor = (i + offset) / range;
                factor = Math.Pow(factor, 1 / gamma);
                factor = Math.Min(Math.Max(factor, 0), 1);
                result[i] = (ushort)Math.Round(factor * ushort.MaxValue);
            }
            return result;
        }
    }

    class Display
    {
        public readonly static DisplayHandle NvDisplay;
        public readonly static string WinDisplay;

        [DllImport("gdi32")]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

        [DllImport("gdi32")]
        public static extern bool DeleteDC([In] IntPtr hdc);

        static Display()
        {
            NvDisplay = DisplayApi.EnumNvidiaDisplayHandle()[0];
            WinDisplay = GetWinDisplayName();
        }
        private static string GetWinDisplayName()
        {
            Screen display = null;
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary)
                {
                    Console.WriteLine(screen.DeviceName);
                    display = screen;
                }
            }

            return display?.DeviceName ?? null;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RAMP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public UInt16[] Red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public UInt16[] Green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public UInt16[] Blue;
    }

    class ColorController
    {
        private readonly int initialDVL;
        private int currentDVL;
        private PrivateDisplayDVCInfo DVCInfo;

        // Gamma Ramps
        private RAMP currentRamps;
        private RAMP originalRamps;

        /**
         * _canceller : Token Source to abort Async-Task (Gamma Value Change)
         * WHY : *I don't know why* set gamma ramp keeps revert soon after modified
         */
        private CancellationTokenSource _canceller;

        #region Singleton Pattern implement
        private static readonly Lazy<ColorController> instance =
            new Lazy<ColorController>(() => new ColorController());

        public static ColorController Instance
        {
            get
            {
                return instance.Value;
            }
        }
        #endregion

        #region Win32 API Calls
        [DllImport("gdi32")]
        private static extern bool GetDeviceGammaRamp(IntPtr hDc, ref RAMP lpRamp);

        [DllImport("gdi32")]
        private static extern bool SetDeviceGammaRamp(IntPtr hDc, ref RAMP lpRamp);
        #endregion

        public int DVL
        {
            get => this.currentDVL;
            set
            {
                if (value <= DVCInfo.MaximumLevel && value >= DVCInfo.MinimumLevel)
                {
                    this.currentDVL = value;
                    DisplayApi.SetDVCLevel(Display.NvDisplay, this.currentDVL);
                    Console.WriteLine("[DVC] Applied");
                }
            }
        }

        private ColorController()
        {
            DVCInfo = DisplayApi.GetDVCInfo(Display.NvDisplay);
            initialDVL = DVCInfo.CurrentLevel;
            DVL = DVCInfo.CurrentLevel;

            // Backup Gamma Ramp
            var hdc = IntPtr.Zero;
            try
            {
                hdc = Display.CreateDC(null, Display.WinDisplay, null, IntPtr.Zero);
                currentRamps = new RAMP();
                originalRamps = new RAMP();
                GetDeviceGammaRamp(hdc, ref originalRamps);
            }
            finally
            {
                if (!IntPtr.Zero.Equals(hdc))
                    Display.DeleteDC(hdc);
            }
        }

        public async void ChangeColorRamp(double brightness = 0.5, double contrast = 0.5, double gamma = 1.0)
        {
            var hdc = IntPtr.Zero;
            try
            {
                hdc = Display.CreateDC(null, Display.WinDisplay, null, IntPtr.Zero);

                ushort[] iArrayValue = CalculateLUT(brightness, contrast, gamma);
                currentRamps.Red = currentRamps.Blue = currentRamps.Green = iArrayValue;

                if (_canceller != null)
                {
                    _canceller.Cancel();
                    _canceller.Dispose();
                }

                _canceller = new CancellationTokenSource();
                var token = _canceller.Token;

                await Task.Run(() =>
                {
                    try
                    {
                        do
                        {
                            SetDeviceGammaRamp(hdc, ref this.currentRamps);
                            Thread.Sleep(250);
                            if (token.IsCancellationRequested)
                                break;
                        } while (true);
                    }
                    catch (System.ObjectDisposedException e) { }
                });


            }
            finally
            {
                Console.WriteLine("[COLOR] Applied.");
                if (!IntPtr.Zero.Equals(hdc))
                    Display.DeleteDC(hdc);
            }
        }

        public void ResetDVL()
        {
            Console.WriteLine("[DVL] Reset to : {0}", this.initialDVL);
            DisplayApi.SetDVCLevel(Display.NvDisplay, DVCInfo.MinimumLevel);
        }

        public void ResetGamma()
        {
            var hdc = IntPtr.Zero;
            try
            {
                hdc = Display.CreateDC(null, Display.WinDisplay, null, IntPtr.Zero);
                SetDeviceGammaRamp(hdc, ref originalRamps);
            }
            finally
            {
                if (!IntPtr.Zero.Equals(hdc))
                    Display.DeleteDC(hdc);
            }
        }

        /*
         * Code from
         * https://github.com/falahati/NvAPIWrapper/issues/20#issuecomment-634551206
         */
        private static ushort[] CalculateLUT(double brightness = 0.5, double contrast = 0.5, double gamma = 2.8)
        {
            const int dataPoints = 256;

            // Limit gamma in range [0.4-2.8]
            gamma = Math.Min(Math.Max(gamma, 0.4), 2.8);
            // Normalize contrast in range [-1,1]
            contrast = (Math.Min(Math.Max(contrast, 0), 1) - 0.5) * 2;
            // Normalize brightness in range [-1,1]
            brightness = (Math.Min(Math.Max(brightness, 0), 1) - 0.5) * 2;
            // Calculate curve offset resulted from contrast
            var offset = contrast > 0 ? contrast * -25.4 : contrast * -32;
            // Calculate the total range of curve
            var range = (dataPoints - 1) + offset * 2;
            // Add brightness to the curve offset
            offset += brightness * (range / 5);
            // Fill the gamma curve
            var result = new ushort[dataPoints];
            for (var i = 0; i < result.Length; i++)
            {
                var factor = (i + offset) / range;
                factor = Math.Pow(factor, 1 / gamma);
                factor = Math.Min(Math.Max(factor, 0), 1);
                result[i] = (ushort)Math.Round(factor * ushort.MaxValue);
            }
            return result;
        }

        public void KillTask()
        {
            if (_canceller != null)
            {
                _canceller.Cancel();
                _canceller.Dispose();
            }
        }
    }
}
