using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanara.PInvoke;

namespace GamerGoggle.Model.ProcessMonitor
{
    public abstract class IProcessMonitor : IDisposable
    {
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        private static User32.HWINEVENTHOOK eventHook;
        private User32.WinEventProc handler;
        private readonly User32.WinEventProc dele;

        public event EventHandler<WinEventArgs>? ForegroundProcessChanged;

        public IProcessMonitor()
        {
            /**
             * To add Windows Event handler dynamically, We gonna use custom event rather than delegate.
             * Handle is for later use. (Getting Process Object)
             */
            dele = new User32.WinEventProc((_, winEvent, hwnd, idObject, idChild, idEventThread, eventTime) =>
            {
                ForegroundProcessChanged?.Invoke(handler, new WinEventArgs()
                {
                    handle = hwnd
                });
            });
            handler += dele;

            eventHook = User32.SetWinEventHook(
                User32.EventConstants.EVENT_SYSTEM_FOREGROUND,
                User32.EventConstants.EVENT_SYSTEM_FOREGROUND,
                IntPtr.Zero,
                handler,
                0, 0, // For every process and threads
                User32.WINEVENT.WINEVENT_OUTOFCONTEXT | User32.WINEVENT.WINEVENT_SKIPOWNPROCESS);
        }

        public void EventFire(User32.HWINEVENTHOOK _, uint winEvent, HWND hwnd, int idObject, int idChild, int idEventThread, uint eventTime)
        {
            ForegroundProcessChanged?.Invoke(this, new WinEventArgs() { handle = hwnd });
        }

        public void Dispose()
        {
            if (handler != null && dele != null)
            {
                #pragma warning disable CS8601 // 가능한 null 참조 할당입니다.
                handler -= dele;
                #pragma warning restore CS8601 // 가능한 null 참조 할당입니다.
            }

            if (eventHook != IntPtr.Zero)
            {
                User32.UnhookWinEvent(eventHook);
            }
        }
    }
}
