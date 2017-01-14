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

namespace 自定义属性
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.SetValue(Student.NameProperty, this.txtBox1.Text);
            txtBox2.Text = (string)stu.GetValue(Student.NameProperty);
            stu.SetBinding(Student.AgeProperty, new Binding("Text") { Source=txtBox3 });//模拟SetValue背后实现的机制
            txtBox4.Text = (string)stu.GetValue(Student.AgeProperty);
        }
    }
}
