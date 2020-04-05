using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace _01Code_Only
{
    class Window1:Window
    {
        private Button button1;

        public Window1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //设置窗体
            this.Width = 285;
            this.Height = 250;
            this.Left = this.Top = 100;
            this.Title = "Use code to create wpf application.";

            //创建停靠的面板对象
            DockPanel panel = new DockPanel();

            //创建按钮对象
            button1 = new Button();
            button1.Content = "Click me";
            button1.Margin = new Thickness(30);
            button1.Click += Button1_Click;

            //创建容器
            IAddChild container = panel;
            container.AddChild(button1);

            container = this;
            container.AddChild(panel);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello word!");
        }
    }
}
