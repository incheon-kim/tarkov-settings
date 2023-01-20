using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using tarkov_settings.GPU;

namespace tarkov_settings
{
    class ColorController
    {
        IGPU gpu = GPUDevice.Instance;

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
            get => gpu.Saturation;
            set
            {
                gpu.Saturation = value;
            }
        }

        private ColorController()
        {

        }

        public void Init()
        {
            // Backup Gamma Ramp
            var hdc = IntPtr.Zero;
            try
            {
                hdc = Display.CreateDC(null, Display.Primary, null, IntPtr.Zero);
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

        public async void ChangeColorRamp(double brightness = 0.5, double contrast = 0.5, double gamma = 1.0, bool reset = true)
        {
            var hdc = IntPtr.Zero;
            try
            {
                hdc = Display.CreateDC(null, Display.Primary, null, IntPtr.Zero);

                try
                {
                    if (_canceller != null)
                    {
                        _canceller.Cancel();
                        _canceller.Dispose();
                    }
                }
                catch (ObjectDisposedException) { }

                if (reset)
                {                    
                   SetDeviceGammaRamp(hdc, ref originalRamps);
                }
                else
                {
                    ushort[] iArrayValue = CalculateLUT(brightness, contrast, gamma);
                    currentRamps.Red = currentRamps.Blue = currentRamps.Green = iArrayValue;

                    _canceller = new CancellationTokenSource();
                    CancellationToken token;
                    try
                    {
                        token = _canceller.Token;
                    }
                    catch (ObjectDisposedException) { }

                    await Task.Run(() =>
                    {
                        try
                        {
                            do
                            {
                                SetDeviceGammaRamp(hdc, ref currentRamps);
                                Thread.Sleep(250);
                                if (token.IsCancellationRequested)
                                    break;
                            } while (true);
                        }
                        catch (ObjectDisposedException) { }
                    });
                }
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

        public void ResetDVL()
        {
            try
            {
                gpu.ResetSaturation();
                Console.WriteLine("[DVL] Reset to : {0}", gpu.InitSaturation);
            }catch (NotImplementedException){ }
        }

        internal void Close()
        {
            ResetDVL();
            ChangeColorRamp(reset: true);

            try
            {
                if (_canceller != null)
                {
                    _canceller.Cancel();
                    _canceller.Dispose();
                }
            }
            catch (ObjectDisposedException) { }
        }

    }
}
