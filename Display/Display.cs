using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using tarkov_settings.GPU;

namespace tarkov_settings
{
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

    class Display
    {
        static IGPU gpu;

        [DllImport("gdi32")]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

        [DllImport("gdi32")]
        public static extern bool DeleteDC([In] IntPtr hdc);

        public readonly static List<string> displays;
        private static string _primary;

        public static string Primary
        {
            get => _primary;
            set
            {
                if (displays.Contains(value))
                {
                    _primary = value;
                    
                }
                else
                {
                    _primary = displays[0];
                }
                try
                {
                    gpu.Load(_primary);
                }
                catch (NotImplementedException) { }
            }
        }

        static Display()
        {
            displays = GetWinDisplays();
            gpu = GPUDevice.Instance;
        }

        private static List<string> GetWinDisplays()
        {
            List<string> list = new List<string>();
            foreach (Screen screen in Screen.AllScreens)
            {
                list.Add(screen.DeviceName);
            }
            return list;
        }
    }
}
