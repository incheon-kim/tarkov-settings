using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GamerGoggle.Model.Applications
{
    internal class WinApplication
    {
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public ImageSource? Icon
        {
            get
            {
                ImageSource? result = null;
                if (string.IsNullOrEmpty(Path) || !File.Exists(Path)) return result;
                using var icon = System.Drawing.Icon.ExtractAssociatedIcon(Path);

                if (icon != null)
                {
                    result = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon
                        (icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
                }

                return result;
            }
        }
    }
}
