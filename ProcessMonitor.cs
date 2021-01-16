using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using NvAPIWrapper.Native;
using NvAPIWrapper.Native.Display.Structures;
using NvAPIWrapper.Display;

namespace tarkov_settings
{
    class ProcessMonitor
    {
        delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        WinEventDelegate dele = null;

        private string currentProcessTitle;
        private string targetProcess;

        private int initialDVCLevel;
        private DisplayHandle primaryDisplay;

        private MainForm pForm;
        public string Current
        {
            get { return currentProcessTitle; }
            set { currentProcessTitle = value; }
        }
        public ProcessMonitor(MainForm pForm, string target)
        {
            this.pForm = pForm;
            this.targetProcess = target;
            dele = new WinEventDelegate(WinEventProc);
            IntPtr m_hhook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT | 2);

            primaryDisplay = DisplayApi.EnumNvidiaDisplayHandle()[0];
            initialDVCLevel = DisplayApi.GetDVCInfo(primaryDisplay).CurrentLevel;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (GetActiveWindowTitle() == this.targetProcess)
            {
                Console.WriteLine("EFT is focused");
                pForm.IsTarkovActive = true;
                pForm.debugText = "Enabled";


                DisplayApi.SetDVCLevel(primaryDisplay, 55);
            }
            else
            {
                Console.WriteLine("EFT is not focused");
                pForm.IsTarkovActive = false;
                pForm.debugText = "Disabled";


                DisplayApi.SetDVCLevel(primaryDisplay, initialDVCLevel);
            }
        }
    }
}
