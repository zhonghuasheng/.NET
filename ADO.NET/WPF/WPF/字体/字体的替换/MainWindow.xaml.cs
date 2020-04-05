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

namespace 字体的替换
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
            txtA.AcceptsReturn = false;
            TxtTest2.AcceptsReturn = true;
            ToolTipService.SetInitialShowDelay ( BtnText2, 3000 );
        }

        private void BtnText_OnClick ( object sender, RoutedEventArgs e )
        {
            MessageBox.Show("你触发了IsCanel按钮");
        }

        private void BtnText2_OnClick ( object sender, RoutedEventArgs e )
        {
           
            MessageBox.Show("你触发了IsDefault按钮");
        }

        private void ToggleButton_Checked ( object sender, RoutedEventArgs e )
        {
            MessageBox.Show("dafafa");
        }

        private void Rep_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("多发发打飞");
        }
    }
}
