using Serilog;
using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using GamerGoggle.Model.ColorController;
using GamerGoggle.Model.ProcessMonitor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using GamerGoggle.Model.Setting;
using System.IO;
using GamerGoggle.Model.GPU;
using GamerGoggle.ViewModel;
using GamerGoggle.Model.Windows;

namespace GamerGoggle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public ServiceProvider? Services { get; }
        private App() : base()
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Verbose()
#else
                .MinimumLevel.Error()
#endif
                .WriteTo.Async(a => a.Trace())
                .CreateLogger();

            Services = InitServices();

            
            #region Load Driver
            if (!(Services?.GetService<IGPU>()?.LoadDriver() ?? false))
                MessageBox.Show($"Failed to load driver");
            if (!(Services?.GetService<IGPU>()?.Initialize(Displays.PrimaryDevice) ?? false))
                MessageBox.Show($"Failed to load driver");
            #endregion

            // Create Window
            Services?.GetService<MainWindow>()?.Show();
        }

        

        private static ServiceProvider? InitServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton(AppSetting.Load());
            
            try
            {
                services.AddSingleton(GPUFactory.Instance);
            } 
            catch (Exception)
            {
                MessageBox.Show("Not supported GPU");
                Application.Current.Shutdown();
            }

            //services.AddSingleton<IColorController, ColorController>();
            services.AddSingleton<IProcessMonitor, ProcessMonitor>();

            #region Services for Main Window
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<MainWindow>();
            #endregion

            return services.BuildServiceProvider();
        }

        private void Application_Exit(object? sender, ExitEventArgs e)
        {
            // Why Disposable pattern does not apply on this sucker?
            Services?.GetService<AppSetting>()?.Save();
            // Dispose every services and service provider.
            Services?.Dispose();
        }
    }
}
