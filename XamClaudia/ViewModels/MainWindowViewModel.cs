using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using Livet;
using XamClaudia.Models;

namespace XamClaudia.ViewModels
{
	class MainWindowViewModel : ViewModel
	{
		#region OSVersion 変更通知プロパティ

		private string _OSVersion;

		public string OSVersion
		{
			get { return this._OSVersion; }
			set
			{
				if (this._OSVersion != value)
				{
					this._OSVersion = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion


		public MainWindowViewModel()
		{
			this.OSVersion = Environment.OSVersion.VersionString;
		}

		public void ToClaudiaColor()
		{
			App.Current.ThemeService.Change(Theme.Claudia);
		}

		public void ToNanamiColor()
		{
			App.Current.ThemeService.Change(Theme.Nanami);
		}

		public void ToPatchouliColor()
		{
			App.Current.ThemeService.Change(Theme.Patchouli);
		}
	}
}
