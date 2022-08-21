using Serilog;
using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using GamerGoggle.Model.ColorController;
using GamerGoggle.Model.ProcessMonitor;
using Microsoft.Extensions.Configuration;
using GamerGoggle.Model.Setting;

namespace GamerGoggle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;

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
            Services = ConfigureServices();

            Services?.GetService<MainWindow>()?.Show();
        }

        public ServiceProvider Services { get; }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IColorController, ColorController>();
            services.AddSingleton<IProcessMonitor, ProcessMonitor>();
            services.AddSingleton(AppSetting.Load());

            services.AddTransient<MainWindow>();

            return services.BuildServiceProvider();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            // Why Disposable pattern does not apply on this sucker?
            Services?.GetService<AppSetting>()?.Save();
            // Dispose every services and service provider.
            Services?.Dispose();
        }
    }
}
