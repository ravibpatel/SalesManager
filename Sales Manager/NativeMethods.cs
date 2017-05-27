using System;
using System.Runtime.InteropServices;

namespace Sales_Manager
{
    static class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
        [DllImport("user32.dll")]
        internal static extern int ShowWindow(IntPtr hWnd, uint Msg);

        internal const uint SW_RESTORE = 0x09;
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
