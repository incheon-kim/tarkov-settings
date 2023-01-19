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
    public class AboutTabViewModel : ITabViewModel
    {
        protected override string Title => "About";

        protected override UserControl _Content => new AboutTabPage();
        public UserControl Content => _Content;
    }
}
