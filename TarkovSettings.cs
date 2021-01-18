using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace tarkov_settings
{
    public class TarkovSettingsPanel : Panel
    {

        public TarkovSettingsPanel()
        {
            this.Dock = DockStyle.Fill;
        }
        private bool FrameLimit
        {
            get { return FrameLimit; }
            set { FrameLimit = value; }
        }
        private uint Fov
        { 
            get { return Fov; }
            set { if (value <= 105)
                    Fov = value; 
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
