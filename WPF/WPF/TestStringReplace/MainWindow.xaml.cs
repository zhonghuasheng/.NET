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

namespace TestStringReplace
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

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            if (cmbTest.SelectedItem.ToString() == "Trim")
            {
                txtOutput.Text = txtInput.Text.Trim()+"解释Trim()去除的是字符串两端的空格";
            }
            if (cmbTest.SelectedItem.ToString() == "Replace")
            {
                txtOutput.Text = txtInput.Text.Replace(" ", "") + "用空代替空格";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbTest.Items.Add("Trim");
            cmbTest.Items.Add("Replace");
            cmbTest.Text=cmbTest.Items[0].ToString();
        }
    }
}
