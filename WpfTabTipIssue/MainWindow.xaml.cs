using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace WpfTabTipIssue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
            
        }

        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            // not raised when TabTip is opened
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            // not raised when TabTip is opened
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var tabTip = @"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe";
            if (File.Exists(tabTip))
            {
                var existingProc = System.Diagnostics.Process.GetProcessesByName("tabtip");
                foreach (var process in existingProc)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch { }
                }
                System.Diagnostics.Process.Start(tabTip);

                //VisualStateManager.GoToElementState(textBox8, "KeyboardOpen", true);
            }
            else
            {
                MessageBox.Show("Unable to find TabTip");
            }
        }
    }
}