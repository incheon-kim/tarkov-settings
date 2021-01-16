using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NvAPIWrapper.Native;
using NvAPIWrapper.Native.Display.Structures;

namespace tarkov_settings
{
    class ColorController
    {
        private int initialDVCLevel;
        private int currentDVCLevel;
        private PrivateDisplayDVCInfo DVCInfo;
        private DisplayHandle primaryDisplay;
        private DisplayHandle[] displays;

        public int DVCLevel
        {
            get => this.currentDVCLevel;
            set
            {
                if(value <= DVCInfo.MaximumLevel && value >= DVCInfo.MinimumLevel)
                {
                    this.currentDVCLevel = value;
                    DisplayApi.SetDVCLevel(primaryDisplay, this.currentDVCLevel);
                }
            }
        }

        public ColorController()
        {
            displays = DisplayApi.EnumNvidiaDisplayHandle();
            primaryDisplay = displays[0];

            DVCInfo = DisplayApi.GetDVCInfo(primaryDisplay);

            initialDVCLevel = DVCInfo.CurrentLevel;
            DVCLevel = DVCInfo.CurrentLevel;
        }

    }
}
