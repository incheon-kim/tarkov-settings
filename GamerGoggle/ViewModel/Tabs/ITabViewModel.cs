using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GamerGoggle.ViewModel.Tabs
{
    public abstract class ITabViewModel : ObservableObject
    {
        protected abstract string Title { get; }
        protected abstract UserControl _Content { get; }
    }
}
