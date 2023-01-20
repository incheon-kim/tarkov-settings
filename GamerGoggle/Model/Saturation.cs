using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model
{
    public class Saturation : ObservableObject
    {
        private int _Value, _Max, _Min;
        public int Value
        {
            get => _Value;
            set
            {
                if (Min <= value && value <= Max)
                    SetProperty(ref _Value, value);
                else if (value < Min)
                    SetProperty(ref _Value, Min);
                else 
                    SetProperty(ref _Value, Max);
            }
        }
        public int Max => _Max;
        public int Min => _Min;
    }
}
