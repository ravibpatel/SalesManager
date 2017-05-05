using System;
using System.Runtime.InteropServices;

namespace Sales_Manager
{
    static class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern int ShowWindow(IntPtr hWnd, uint msg);

        internal const uint SW_RESTORE = 0x09;
    }
}
