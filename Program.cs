using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NvAPIWrapper.GPU;

namespace tarkov_settings
{
    static class Program
    {

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NvAPIWrapper.NVIDIA.Initialize();
            PhysicalGPU [] gpus = NvAPIWrapper.GPU.PhysicalGPU.GetPhysicalGPUs();
            foreach (PhysicalGPU gpu in gpus)
            {
                System.Console.WriteLine(gpu);
            }
            if ( gpus.Length < 1 )
            {
                MessageBox.Show("Nvidia GPU 를 찾을 수 없습니다.", "Nvidia GPU is not found!", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            NvAPIWrapper.NVIDIA.Unload();
        }
    }
}
