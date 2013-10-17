using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PerMonitorDpi.Models.Win32
{
	internal class NativeMethods
	{
		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromWindow(IntPtr hwnd, MonitorDefaultTo dwFlags);

		[DllImport("SHCore.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
		public static extern void GetDpiForMonitor(IntPtr hmonitor, MonitorDpiType dpiType, ref uint dpiX, ref uint dpiY);
	}
}
