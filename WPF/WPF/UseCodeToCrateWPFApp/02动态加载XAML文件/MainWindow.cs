using System;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Controls;
using System.IO;

namespace _02动态加载XAML文件
{
    class MainWindow : Window
    {
        private Button myButton;
        public MainWindow() { }

        public MainWindow(string xamlFile)
        {
            //设置窗体
            this.Width = this.Height = 300;
            this.Left = this.Top = 20;
            this.Title = "动态加载XAML";

            //从一个XAML文件中获取XAML内容
            DependencyObject rootElement;
            using (FileStream fs = new FileStream(xamlFile,FileMode.Open))
            {
                rootElement = XamlReader.Load(fs) as DependencyObject;
            }
            //将XAML中的标记加载到当前窗体
            this.Content = rootElement;
            myButton = LogicalTreeHelper.FindLogicalNode(rootElement, "button1") as Button;
            myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "I have changed!";
        }
    }
}
