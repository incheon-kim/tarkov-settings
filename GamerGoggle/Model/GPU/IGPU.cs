using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model.GPU
{
    public interface IGPU : IDisposable
    {
        bool LoadDriver();
        bool Initialize(object? param);
        void SetBrightness(int brightness);
        void SetContrast(int contrast); 
        void SetGamma(int gamma);
        void SetSaturation(int saturation);
    }
}
