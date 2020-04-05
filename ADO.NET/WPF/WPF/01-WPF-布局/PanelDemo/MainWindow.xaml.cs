using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PanelDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowFormExpend.FullScreen(window);//调用全屏方法
            this.InitEvent();
        }
        private void InitEvent()
        {
            this.KeyDown += delegate(object sender, KeyEventArgs e)
            {
                if (e.Key == Key.Escape)
                {
                    this.Close();
                }
                if (e.Key == Key.Enter)
                {
                    this.FullScreen();
                }
                if (e.Key == Key.E)
                {
                    this.ExitFullScreen();
                }
            };
        }
    }
}
