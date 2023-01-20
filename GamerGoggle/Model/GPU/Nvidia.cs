using GamerGoggle.Model.Windows;
using NvAPIWrapper.Native;
using NvAPIWrapper.Native.Display.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model.GPU
{
    public class Nvidia : IGPU
    {
        private DisplayHandle displayHandle;

        public bool LoadDriver()
        {
            try
            {
                NvAPIWrapper.NVIDIA.Initialize();
            }
            catch (NvAPIWrapper.Native.Exceptions.NVIDIAApiException)
            {
                // Failed to load driver
                return false;
            }

            return true;
        }

        public bool Initialize(object? param)
        {
            var display = param as WinDisplay;
            if (display == null) return false;

            displayHandle = DisplayApi.GetAssociatedNvidiaDisplayHandle(display.DevicePath);
            PrivateDisplayDVCInfo dvcInfo = DisplayApi.GetDVCInfo(displayHandle);

            return true;
        }

        public void SetBrightness(int brightness)
        {
            throw new NotImplementedException();
        }

        public void SetContrast(int contrast)
        {
            throw new NotImplementedException();
        }

        public void SetGamma(int gamma)
        {
            throw new NotImplementedException();
        }

        public void SetSaturation(int saturation)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
