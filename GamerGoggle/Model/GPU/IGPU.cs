using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model.GPU
{
    internal interface IGPU : IDisposable
    { 
        Saturation saturation { get; set; }
    }
}
