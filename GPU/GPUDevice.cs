using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static GPUDevice()
        {
            Vendor = GetGPUVendor();
        }
        public static GPUVendor Vendor;
        public static GPUVendor GetGPUVendor()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["Name"].ToString().Contains("NVIDIA"))
                    {
                        return GPUVendor.NVIDIA;
                    }
                    else if (obj["Name"].ToString().Contains("AMD"))
                    {


                        return GPUVendor.AMD;
                    }
                    else
                    {
                        return GPUVendor.ETC;
                    }
                }

                return GPUVendor.ETC;
            }
        }
    }
}
