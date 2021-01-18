using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace tarkov_settings
{
    static class NativeMethods
    {
        public delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        public static WinEventDelegate dele = null;

        #region Win32 API Calls
        [DllImport("user32.dll")]
        public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        #endregion
        public static string GetActiveWindowTitle()
        {
            try
            {
                IntPtr handle = GetForegroundWindow();
                uint threadID = GetWindowThreadProcessId(handle, out uint processID);
                return Process.GetProcessById(Convert.ToInt32(processID)).ProcessName;
            }
            catch
            {
                return null;
            }
        }
    }
    class ProcessMonitor
    {
        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        private readonly ColorController cController = ColorController.Instance;

        private HashSet<string> pTargets = new HashSet<string>();

        #region Singleton Pattern implement
        private static readonly Lazy<ProcessMonitor> instance =
            new Lazy<ProcessMonitor>(() => new ProcessMonitor());

        public static ProcessMonitor Instance
        {
            get
            {
                return instance.Value;
            }
        }
        #endregion

        public MainForm Parent { get; set; }

        public ProcessMonitor()
        {
            NativeMethods.dele = new NativeMethods.WinEventDelegate(WinEventProc);
            IntPtr m_hhook = NativeMethods.SetWinEventHook(EVENT_SYSTEM_FOREGROUND,
                EVENT_SYSTEM_FOREGROUND,
                IntPtr.Zero,
                NativeMethods.dele,
                0, 0, WINEVENT_OUTOFCONTEXT | 2);
        }

        public void Add(string process)
        {
            this.pTargets.Add(process);
        }

        /**
         * Window Focus changed Event Handler
         */
        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            //cController.AbortThread();
            Console.WriteLine("Running Tasks : " + GetWorkingThreads());
            Console.WriteLine("Focused Process : {0}", NativeMethods.GetActiveWindowTitle());

            if (this.pTargets.Contains(NativeMethods.GetActiveWindowTitle()))
            {
                Console.WriteLine("[pMonitor] Target Process is focused");

                var (b, c, g, dvl) = Parent.GetColorValue();
                cController.ChangeColorRamp(b, c, g);
                cController.DVL = dvl;
                Console.WriteLine("B : {0:F2} C: {1:F2} G: {2:F2} DVL: {3}", b, c, g, dvl);
            }
            else
            {
                Console.WriteLine("[pMonitor] Target Process is not focused");

                cController.ChangeColorRamp();
                cController.ResetDVL();
            }
        }

        /**
         * Reset to original color settings before exit
         */
        public void Reset()
        {
            Console.WriteLine("[pMonitor] Color Reset");
            cController.ResetDVL();
            cController.ResetGamma();
            cController.KillTask();
        }

        private static int GetWorkingThreads()
        {
            System.Threading.ThreadPool.GetMaxThreads(out int maxThreads, out int _);
            System.Threading.ThreadPool.GetAvailableThreads(out int availableThreads, out _);
            return maxThreads - availableThreads;
        }
    }
}
