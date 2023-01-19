using CommunityToolkit.Mvvm.ComponentModel;
using GamerGoggle.View.TabPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GamerGoggle.ViewModel.Tabs
{
    public class MainTabViewModel : ITabViewModel
    {
        protected override string Title => "❤️";

        protected override UserControl _Content => new MainTabPage();
    }
}
