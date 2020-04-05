using System;
using System.Windows;

namespace _02动态加载XAML文件
{
    class Program:Application
    {
        [STAThread]
        static void Main()
        {
            Program p = new Program();
            p.MainWindow = new MainWindow("Window1.xaml");
            p.MainWindow.ShowDialog();
        }
    }
}
