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

namespace _05绑定到List泛型集合
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow ( )
        {
            InitializeComponent ( );
            //准备数据源
            List<Student> stuList =new List<Student> ( )
            {
                new Student(){Id = 001,Name = "Apple",Age = 12},
                new Student(){Id = 002,Name = "Banana",Age = 13},
                new Student(){Id = 003,Name = "Cocoa",Age = 14},
                new Student(){Id = 004,Name = "Dog",Age = 15},
                new Student(){Id = 005,Name = "Func",Age = 16},
                new Student(){Id = 006,Name = "Great",Age = 17}
            };
            //为ListBox设置Binding
            this.ListBoxStudents.ItemsSource = stuList;
            this.ListBoxStudents.DisplayMemberPath = "Name";
            //为TextBox设置Binding
            //Binding binding=new Binding("SelectedItem.Id"){Source = this.ListBoxStudents};
            //this.TxtBoxId.SetBinding(TextBox.TextProperty, binding);

        }
    }
}
