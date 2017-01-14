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

namespace _032使用StackPanel面板进行简单布局
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtUserName_LostFocus(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = "失去光标";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            btnHello.Margin = new Thickness(100,100,20,20);
        }
    }
}
