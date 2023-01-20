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
                using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        var deviceName = obj["Name"].ToString();

                        if (deviceName.Contains("NVIDIA"))
                        {
                            return new NVIDIA(GPUVendor.NVIDIA);
                        }
                        else if (deviceName.Contains("AMD") || deviceName.Contains("Radeon"))
                        {
                            return new AMD(GPUVendor.AMD);
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                    throw new NotImplementedException();
                }
            });
        public static IGPU Instance
        {
            get => instance.Value;
        }
    }
}
