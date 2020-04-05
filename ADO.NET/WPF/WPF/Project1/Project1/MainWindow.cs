using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Project1
{
	class MainWindow:Window
	{
		public MainWindow(string windowTitle, int height, int width)
		{
			this.Title = windowTitle;
			this.Height = height;
			this.Width = width;
			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
		}
	}
}
