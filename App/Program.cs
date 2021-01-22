using System;
using System.Windows.Forms;

using tarkov_settings.GPU;

namespace tarkov_settings
{
    static class Program
    {
        private static MainForm mForm;

        [STAThread]
        static void Main()
        {
            IGPU gpu = null;
            try
            {
                gpu = GPUDevice.Instance;
                if(gpu.Vendor == GPUVendor.AMD)
                {
                    /* AMD Saturation (equals to Digital Vibrance of Nvidia) is not supported yet. */
                    System.Windows.Forms.MessageBox.Show(
                            "AMD Device Detected - Saturation is not supported yet.",
                            "Warning",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Warning
                        );
                }
            } catch (NotImplementedException)
            {
                System.Windows.Forms.MessageBox.Show(
                        "Intel/Nvidia Optimus/Etc Device Detected - Will be supported soon",
                        "Nvidia GPU is not found!",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
            }

            // Open Main Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mForm = new MainForm();
            Application.Run(mForm);

            // Unload NvAPI dll after Application.Exit()
            if(gpu != null)
                gpu.Close();
        }
    }
}
