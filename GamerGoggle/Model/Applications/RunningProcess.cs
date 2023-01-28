using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerGoggle.Model.Applications
{
    internal class RunningProcess
    {
        static List<WinApplication> GetList()
        {
            var list = new List<WinApplication>();

            var processes = Process.GetProcesses();
            
            foreach (var process in processes)
            {
                try
                {
                    var procName = process.ProcessName;
                    var procPath = process.MainModule?.FileName;
                    if (procPath == null) continue;

                    var winApp = new WinApplication()
                    {
                        Name = procName,
                        Path = procPath,
                    };

                    list.Add(winApp);
                }
                catch { continue; }
            }

            return list;
        }
    }
}
