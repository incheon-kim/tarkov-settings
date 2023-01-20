using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace GamerGoggle.Model.Windows
{
    public class WinDisplay
    {
        public WinDisplay(string path, string name, bool isprimary)
        {
            DevicePath = path;
            FamiliarName = name;
            IsPrimary = isprimary;
        }

        public string DevicePath { get; private set; } = string.Empty;
        public string FamiliarName { get; private set; } = string.Empty;
        public bool IsPrimary { get; private set; } = false;
    }
    public class Displays
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool EnumDisplayDevices(string? lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct DISPLAY_DEVICE
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
        private enum DisplayDeviceStateFlags : int
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

        public static ReadOnlyCollection<WinDisplay> Devices { get; private set; }
        public static WinDisplay? PrimaryDevice { get; private set; } = null;

        static Displays()
        {
            var list = new List<WinDisplay>();
            DISPLAY_DEVICE device = new();
            device.cb = Marshal.SizeOf<DISPLAY_DEVICE>();
            var idx = 0U;

            while (EnumDisplayDevices(null, idx++, ref device, 0))
            {
                if (device.StateFlags.HasFlag(DisplayDeviceStateFlags.MirroringDriver)) continue;
                if (device.StateFlags.HasFlag(DisplayDeviceStateFlags.Remote)) continue;

                if (device.StateFlags.HasFlag(DisplayDeviceStateFlags.AttachedToDesktop))
                {
                    var devicePath = device.DeviceName;
                    EnumDisplayDevices(device.DeviceName, 0, ref device, 0);

                    var display = new WinDisplay(devicePath, device.DeviceString, device.StateFlags.HasFlag(DisplayDeviceStateFlags.PrimaryDevice));
                    list.Add(display);

                    if (device.StateFlags.HasFlag(DisplayDeviceStateFlags.PrimaryDevice))
                    {
                        PrimaryDevice = display;
                    }
                }
            }
            Devices = list.AsReadOnly();
        }
        private Displays() { }
    }
}
