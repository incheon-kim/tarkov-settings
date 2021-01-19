using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using NvAPIWrapper.GPU;
using tarkov_settings.GPU;
using tarkov_settings.Setting;

namespace tarkov_settings
{
    static class Program
    {
        private static MainForm mForm;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            switch (GPUDevice.Vendor)
            {
                case GPUDevice.GPUVendor.NVIDIA:
                    NvAPIWrapper.NVIDIA.Initialize();
                    PhysicalGPU[] gpus = NvAPIWrapper.GPU.PhysicalGPU.GetPhysicalGPUs();
                    foreach (PhysicalGPU gpu in gpus)
                    {
                        System.Console.WriteLine(gpu);
                    }
                    if (gpus.Length < 1)
                    {
                        MessageBox.Show("Nvidia GPU 를 찾을 수 없습니다.", "Nvidia GPU is not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case GPUDevice.GPUVendor.AMD:
                    System.Windows.Forms.MessageBox.Show("Intel/Etc Device Detected - Will be supported soon",
                            "Nvidia GPU is not found!",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error
                        );
                    System.Threading.Thread.Sleep(1000);
                    Application.Exit();
                    break;
                default:
                    /* AMD Sturation(equals to Digital Vibrance of Nvidia) is not supported yet. */
                    System.Windows.Forms.MessageBox.Show("AMD Device Detected - Will be supported soon",
                            "Nvidia GPU is not found!",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error
                        );
                    System.Threading.Thread.Sleep(1000);
                    Application.Exit();
                    break;
            }

            // Open Main Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mForm = new MainForm();
            Application.Run(mForm);

            // Unload NvAPI dll after Application.Exit()
            if (GPUDevice.Vendor == GPUDevice.GPUVendor.NVIDIA)
                NvAPIWrapper.NVIDIA.Unload();
        }
    }
}
