using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GamerGoggle.Model.Setting
{
    public class AppSetting : ISetting<AppSetting>
    {
        public double Brightness { get; set; } = 0.5;
        public double Contrast { get; set; } = 0.5;
        public double Gamma { get; set; } = 1.0;
        public int Saturation { get; set; } = 0;
        public IEnumerable<string> pTargets { get; set; } = new HashSet<string>()
        {
            "EscapeFromTarkov"
#if DEBUG
            ,"msedge"
#endif
        };
        public string displayName { get; set; } = @"\\.\DISPLAY1";
        public bool minimizeOnStart { get; set; } = false;
    }
}
