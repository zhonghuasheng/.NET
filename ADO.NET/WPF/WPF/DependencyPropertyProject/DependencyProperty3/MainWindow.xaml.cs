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

namespace DependencyProperty3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student stu;
        public MainWindow ( )
        {
            InitializeComponent ( );
            stu=new Student();
            stu.SetBinding(Student.NameProperty, new Binding("Text") {Source = txtBox1});
            txtBox2.SetBinding(TextBox.TextProperty, new Binding("Name") {Source = stu});
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
           // stu=new Student();
           // stu.Name = "张三啊";
           // //绑定数据源
           //// stu.SetBinding(Student.NameProperty, new Binding("Text") {Source = txtBox1});
           // //数据目标绑定到数据源
           // txtBox2.SetBinding(TextBox.TextProperty, new Binding("Name") {Source = stu});
        }
    }
}
