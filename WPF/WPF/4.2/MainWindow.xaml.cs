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

namespace _4._2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid grid1 = this.Content as Grid;//MainWindow.Content属性引用着Grid的实例，而Grid的实例的Children[0]又引用着TextBox的实例
            TextBox textBox = grid1.Children[0] as TextBox;
            if (string.IsNullOrEmpty(textBox.Name))
            {
                textBox.Text = "hello";
            }
            else
            {
                textBox.Text = textBox.Name;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string str = this.FindResource("myString") as string;
            this.textBox2.Text = str;
        }

        private void buttonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DependencyObject level1 = VisualTreeHelper.GetParent(btn);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);
            MessageBox.Show(level3.GetType().ToString());
        }
    }

    class MyButton:Button
    {
        public Type UserWindowType { get; set; }

        protected override void OnClick()
        {
            base.OnClick();
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if (win != null)
            {
                win.ShowDialog();
            }
        }
    }
}
