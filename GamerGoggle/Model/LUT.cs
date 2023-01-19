using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model
{
    public class LUT : ObservableObject
    {
        private double _Brightness;
        private double _Contrast;
        private double _Gamma;

        public double Brightness
        {
            get => _Brightness;
            set => SetProperty(ref _Brightness, value);
        }

        public double Contrast
        {
            get => _Contrast;
            set => SetProperty(ref _Contrast, value);
        }

        public double Gamma
        {
            get => _Gamma;
            set => SetProperty(ref _Gamma, value);
        }
    }
}
