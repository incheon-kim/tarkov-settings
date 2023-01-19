using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model.GPU
{
    public enum GPUVendor
    {
        NVIDIA,
        AMD,
        INTEL,
        ETC
    }
    public class GPUFactory
    {
        private static readonly Lazy<IGPU> _Instance =
            new(() =>
            {
                using var searcher = new ManagementObjectSearcher("select * from Win32_VideoController");

                var queryResult = searcher.Get();
                var deviceNames = new List<string>();

                lock (queryResult.SyncRoot) 
                {
                    foreach(var device in queryResult)
                    {
                        var name = device.GetPropertyValue("Name")?.ToString() ?? null;
                        if (name != null)
                        {
                            deviceNames.Add(name);
                        }
                    }
                }

                if (deviceNames.Any((deviceName) => deviceName.Contains("NVIDIA", StringComparison.OrdinalIgnoreCase) || deviceName.Contains("GeForce", StringComparison.OrdinalIgnoreCase)))
                {
                    return new Nvidia();
                }
                else if (deviceNames.Any((deviceName) => deviceName.Contains("AMD", StringComparison.OrdinalIgnoreCase) || deviceName.Contains("Radeon", StringComparison.OrdinalIgnoreCase)))
                {
                    return new AMD();
                }
                else
                {
                    throw new NotImplementedException();
                }
            });
        public static IGPU Instance => _Instance.Value;
    }
}
