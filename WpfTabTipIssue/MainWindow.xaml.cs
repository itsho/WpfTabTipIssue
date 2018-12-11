using System.IO;
using System.Windows;

namespace WpfTabTipIssue
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			var tabTip = @"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe";
			if (File.Exists(tabTip))
			{
				System.Diagnostics.Process.Start(tabTip);
			}
			else
			{
				MessageBox.Show("Unable to find TabTip");
			}
		}
	}
}
