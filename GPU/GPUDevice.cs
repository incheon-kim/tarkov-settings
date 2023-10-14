using System;
using System.Management;

namespace tarkov_settings.GPU
{
    public enum GPUVendor
    {
        NVIDIA = 1,
        AMD = 2,
        ETC = 3
    }

    class GPUDevice
    {
        private static readonly Lazy<IGPU> instance =
            new Lazy<IGPU>(() =>
            {
                var vendor = GPUVendor.ETC;
                using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        var deviceName = obj["Name"].ToString();

                        if (deviceName.Contains("NVIDIA") || deviceName.Contains("Geforce"))
                        {
                            vendor = GPUVendor.NVIDIA;
                        }
                        else if (deviceName.Contains("AMD") || deviceName.Contains("Radeon"))
                        {
                            // Prioritize NVidia graphics
                            if (vendor != GPUVendor.NVIDIA)
                                vendor = GPUVendor.AMD;
                        }
                    }

                    switch (vendor)
                    {
                        case GPUVendor.NVIDIA:
                            return new NVIDIA(vendor);
                        case GPUVendor.AMD:
                            return new AMD(vendor);
                        default:
                            throw new NotImplementedException();
                    }
                }
            });
        public static IGPU Instance
        {
            get => instance.Value;
        }
    }
}
