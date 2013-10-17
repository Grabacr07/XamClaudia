using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace XamClaudia.Views
{
	/// <summary>
	/// Claudia.xaml の相互作用ロジック
	/// </summary>
	public partial class Claudia
	{
		public Claudia()
		{
			InitializeComponent();
		}

		#region GlassVisible 依存関係プロパティ

		public bool GlassVisible
		{
			get { return (bool)this.GetValue(Claudia.GlassVisibleProperty); }
			set { this.SetValue(Claudia.GlassVisibleProperty, value); }
		}
		public static readonly DependencyProperty GlassVisibleProperty =
			DependencyProperty.Register("GlassVisible", typeof(bool), typeof(Claudia), new UIPropertyMetadata(true));

		#endregion
	}
}
