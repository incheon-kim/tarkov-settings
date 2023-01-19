using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model.GPU
{
    public class AMD : IGPU
    {
        internal const string Atiadlxx_FileName = "atiadlxx.dll";
        internal const string Kernel32_FileName = "kernel32.dll";

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Initialize(object param)
        {
            throw new NotImplementedException();
        }

        public bool LoadDriver()
        {
            throw new NotImplementedException();
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
    }
}
