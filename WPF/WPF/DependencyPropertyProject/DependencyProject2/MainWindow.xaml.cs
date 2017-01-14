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

namespace DependencyProject2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student stu;
        private Binding binding;
        public MainWindow ( )
        {
            InitializeComponent ( );
            stu=new Student();
            binding=new Binding("Text"){Source = txtBox1};
            BindingOperations.SetBinding(stu, Student.NameProperty, binding);
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu.GetValue(Student.NameProperty).ToString());
        }

        private void BtnTest1_OnClick(object sender, RoutedEventArgs e)
        {
            txtBox2.SetBinding ( TextBox.TextProperty,binding );
        }
    }
}
