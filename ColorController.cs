using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Threading;

using NvAPIWrapper.Native;
using NvAPIWrapper.Native.Display.Structures;


namespace tarkov_settings
{
    class ColorController
    {
        private int initialDVCLevel;
        private int currentDVCLevel;

        private PrivateDisplayDVCInfo DVCInfo;
        private DisplayHandle primaryDisplay;
        private DisplayHandle[] displays;

        // for gamma control
        private RAMP currentRamps;
        private RAMP originalRamps;
        private int _gamma;
        private Thread gThread;

        private static readonly Lazy<ColorController> instance =
            new Lazy<ColorController>(() => new ColorController());

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct DISPLAY_DEVICE
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cb;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceString;
            [MarshalAs(UnmanagedType.U4)]
            public DisplayDeviceStateFlags StateFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceKey;
        }

        [Flags()]
        public enum DisplayDeviceStateFlags : int
        {
            /// <summary>The device is part of the desktop.</summary>
            AttachedToDesktop = 0x1,
            MultiDriver = 0x2,
            /// <summary>The device is part of the desktop.</summary>
            PrimaryDevice = 0x4,
            /// <summary>Represents a pseudo device used to mirror application drawing for remoting or other purposes.</summary>
            MirroringDriver = 0x8,
            /// <summary>The device is VGA compatible.</summary>
            VGACompatible = 0x10,
            /// <summary>The device is removable; it cannot be the primary display.</summary>
            Removable = 0x20,
            /// <summary>The device has more display modes than its output devices support.</summary>
            ModesPruned = 0x8000000,
            Remote = 0x4000000,
            Disconnect = 0x2000000
        }


        [DllImport("gdi32")]
        private static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

        [DllImport("gdi32")]
        private static extern bool DeleteDC([In] IntPtr hdc);

        [DllImport("gdi32")]
        private static extern bool GetDeviceGammaRamp(IntPtr hDc, ref RAMP lpRamp);

        [DllImport("gdi32")]
        private static extern bool SetDeviceGammaRamp(IntPtr hDc, ref RAMP lpRamp);

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

        public int DVCLevel
        {
            get => this.currentDVCLevel;
            set
            {
                if (value <= DVCInfo.MaximumLevel && value >= DVCInfo.MinimumLevel)
                {
                    this.currentDVCLevel = value;
                    DisplayApi.SetDVCLevel(primaryDisplay, this.currentDVCLevel);
                }
            }
        }

        public int Gamma
        {
            get => this._gamma;
            set
            {
                if (gThread != null && gThread.IsAlive)
                {
                    Console.WriteLine("Thread Aborting");
                    gThread.Abort();
                }

                if (value > 256)
                    this._gamma = 256;
                else if (value < 1)
                    this._gamma = 1;
                else
                    this._gamma = value;

                currentRamps.Red = new ushort[256];
                currentRamps.Green = new ushort[256];
                currentRamps.Blue = new ushort[256];

                Screen display = Screen.AllScreens[0];
                var hdc = IntPtr.Zero;

                try
                {
                    hdc = CreateDC(null, display.DeviceName, null, IntPtr.Zero);


                    for (int i = 1; i < 256; i++)
                    {
                        int iArrayValue = i * (this._gamma + 128);

                        if (iArrayValue > 65535)
                            iArrayValue = 65535;

                        currentRamps.Red[i] = (ushort)iArrayValue;
                        currentRamps.Blue[i] = currentRamps.Green[i] = (ushort)iArrayValue;
                    }
                    gThread = new Thread(() => this.changeGamma(hdc));
                    gThread.Start();
                    Console.WriteLine(SetDeviceGammaRamp(hdc, ref currentRamps));

                }
                finally
                {
                    
                }
            }
        }

        public static ColorController Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private ColorController()
        {
            this.displays = DisplayApi.EnumNvidiaDisplayHandle();

            this.primaryDisplay = displays[0];

            this.DVCInfo = DisplayApi.GetDVCInfo(primaryDisplay);

            this.initialDVCLevel = DVCInfo.CurrentLevel;
            this.DVCLevel = DVCInfo.CurrentLevel;

            // Gamma
            Screen display = null;
            foreach(Screen screen in Screen.AllScreens)
            {
                if (screen.Primary) {
                    Console.WriteLine(screen.DeviceName);
                    display = screen;
                }
            }

            if (display is null)
                System.Windows.Forms.Application.Exit();
                


            var hdc = IntPtr.Zero;
            try
            {
                hdc = CreateDC(null, display.DeviceName, null, IntPtr.Zero);
                currentRamps = new RAMP();
                originalRamps = new RAMP();
                GetDeviceGammaRamp(hdc, ref originalRamps);
            }
            finally
            {
                if (!IntPtr.Zero.Equals(hdc))
                    DeleteDC(hdc);
            }
            
            Console.WriteLine("Initial DVC" + this.initialDVCLevel);
            Console.WriteLine("Current DVCLEvel" + this.DVCLevel);
        }

        public void ResetDVCLevel()
        {
            this.DVCLevel = initialDVCLevel;
        }

        private void changeGamma(IntPtr hdc)
        {
            try
            {
                while (true)
                {
                    Console.Write(".");
                    SetDeviceGammaRamp(hdc, ref currentRamps);
                    Thread.Sleep(250);
                }
            } catch (Exception e)
            {
                if (!IntPtr.Zero.Equals(hdc))
                    DeleteDC(hdc);
                Console.WriteLine("Gamma Change Thread Stopped ");
            }
        }

        public void ResetGamma()
        {
            Screen display = Screen.AllScreens[0];
            var hdc = IntPtr.Zero;
            try
            {
                hdc = CreateDC(null, display.DeviceName, null, IntPtr.Zero);
                SetDeviceGammaRamp(hdc, ref originalRamps);
            }
            finally
            {
                if (!IntPtr.Zero.Equals(hdc))
                    DeleteDC(hdc);
            }
        }
    }
}
