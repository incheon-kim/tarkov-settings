using GamerGoggle.Model.ColorController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Vanara.PInvoke;
using Serilog;
using GamerGoggle.Model.Setting;

namespace GamerGoggle.Model.ProcessMonitor
{
    internal class ProcessMonitor : IProcessMonitor
    {
        private IColorController colorController;
        private AppSetting appSetting;
        public ProcessMonitor(IColorController colorController, AppSetting appSetting)
        {
            this.colorController = colorController;
            this.appSetting = appSetting;
            ForegroundProcessChanged += ForegroundHandler;
        }

        private void ForegroundHandler(object? sender, WinEventArgs args)
        {
            User32.GetWindowThreadProcessId(args.handle, out var processId);
            using var proc = Process.GetProcessById((int)processId);

            var procname = proc.ProcessName.ToLower();
            if (appSetting.pTargets.Contains(procname))
            {
                // target
                Log.Logger.Information(procname);
            }
            else
            {
                Log.Logger.Verbose(procname);
                // non-target
            }

        }
    }
}
