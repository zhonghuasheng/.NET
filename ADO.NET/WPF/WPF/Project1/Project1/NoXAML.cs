using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;//PresentationFramework.dll
using System.Windows;//System.Windows.Forms

namespace Project1 {
	class NoXAML :Application//添加WindowsBase.dll
	{
		[STAThread]
		static void Main(string[] args) 
		{
			NoXAML app = new NoXAML();
			app.Startup+=AppStartUp;
			
			foreach (var item in app.Properties) {
				MessageBox.Show(item.ToString());
			}

			app.Exit += AppExit;
			app.Run();
		}

		static void AppExit(object sender,ExitEventArgs e)
		{
			MessageBox.Show("App has exit");
		}

		static void AppStartUp(object sender, StartupEventArgs e) 
		{
			Window mainwindow = new Window();
			mainwindow.Title = "创建不使用XAML的WPF应用程序";
			mainwindow.Height = 200;
			mainwindow.Width = 300;
			mainwindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			mainwindow.Show();
		}
	}
}
