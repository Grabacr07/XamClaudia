using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using PerMonitorDpi.Models.Win32;

namespace PerMonitorDpi.Models
{
	public static class PerMonitorDpiService
	{
		public static bool IsSupported
		{
			get
			{
				var version = Environment.OSVersion.Version;
				return version.Major == 6 && version.Minor == 3;
			}
		}

		public static Dpi GetDpi(this HwndSource hwndSource, MonitorDpiType dpiType = MonitorDpiType.Default)
		{
			if (!IsSupported) return Dpi.Default;

			var hmonitor = NativeMethods.MonitorFromWindow(
				hwndSource.Handle,
				MonitorDefaultTo.MONITOR_DEFAULTTONEAREST);

			uint dpiX = 1, dpiY = 1;
			NativeMethods.GetDpiForMonitor(hmonitor, dpiType, ref dpiX, ref dpiY);

			return new Dpi(dpiX, dpiY);
		}
	}
}
