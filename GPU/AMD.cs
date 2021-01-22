using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarkov_settings.GPU
{
    class AMD : IGPU
    {
        private GPUVendor _vendor;
        public GPUVendor Vendor
        {
            get => this._vendor;
        }

        public int Saturation
        {
            get;set;
        }

        int IGPU.MaxSaturation => throw new NotImplementedException();

        int IGPU.MinSaturation => throw new NotImplementedException();

        int IGPU.InitSaturation => throw new NotImplementedException();

        public AMD(GPUVendor vendor)
        {
            this._vendor = vendor;
        }

        public void ResetSaturation()
        {
            throw new NotImplementedException();
        }

        public void Load(string display)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
