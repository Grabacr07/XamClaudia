using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace XamClaudia.Models
{
	public enum Theme
	{
		Claudia, Nanami, Patchouli,
	}

	public class ThemeService
	{
		private readonly App app;
		public Theme Current { get; private set; }

		public ThemeService(App app)
		{
			this.app = app;
			this.Change(Theme.Claudia);
		}

		public void Change(Theme theme)
		{
			if (this.Current == theme) return;

			var uri = new Uri(string.Format(@"pack://application:,,,/Themes/ClaudiaWpf.{0}Color.xaml", theme));
			var dic = new ResourceDictionary { Source = uri };

			dic.Keys.OfType<string>()
				.Where(key => this.app.Resources.Contains(key))
				.ForEach(key => this.app.Resources[key] = dic[key]);

			this.Current = theme;
		}
	}
}
