using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using GamerGoggle.Model.ColorController;
using GamerGoggle.Model.ProcessMonitor;
using GamerGoggle.Model.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerGoggle.ViewModel.Tabs;

namespace GamerGoggle.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        private AppSetting _setting;
        private IColorController _colorController;
        private IProcessMonitor _processMonitor;

        public ObservableObject CurrentView { get; set; }
        private List<ObservableObject> _Views;
        public List<ObservableObject> Views
        {
            get; private set;
        }
        
        public MainWindowViewModel(AppSetting setting, IColorController colorController, IProcessMonitor processMonitor)
        {
            _setting = setting;
            _colorController = colorController;
            _processMonitor = processMonitor;
            Views = new List<ObservableObject>()
            {
                new MainTabViewModel(),
                new HotKeyTabViewModel(),
                new AboutTabViewModel(),
            };
        }

        public void ProcessHandler(object s, WinEventArgs args)
        {

        }
    }
}
