using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Project1
{
	class NoXAML2:Application
	{
		[STAThread]
		static void Main(string[] args)
		{
			NoXAML2 app = new NoXAML2();
			app.Startup += new StartupEventHandler(AppStart);
			app.Exit += new ExitEventHandler(AppExit);
			app.Run();
		}

		static void AppStart(object sender,StartupEventArgs e)
		{
			//Window win = new Window();
			//win.Title = "NoXAML";
			//win.Width = 300;
			//win.Height = 200;
			//win.WindowStartupLocation = WindowStartupLocation.CenterScreen;

			MainWindow mw = new MainWindow("NoXAML",300,200);
			mw.Show();
		}

		static void AppExit(object sender,ExitEventArgs e)
		{
			MessageBox.Show("AppExit");
		}
	}
}
