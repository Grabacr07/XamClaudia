using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XamClaudia.Models;
using XamClaudia.Views;

namespace XamClaudia
{
	public partial class App
	{
		public ThemeService ThemeService { get; private set; }

		public new static App Current
		{
			get { return (App)Application.Current; }
		}

		public App()
		{
			this.ThemeService = new ThemeService(this);
		}
	}
}
