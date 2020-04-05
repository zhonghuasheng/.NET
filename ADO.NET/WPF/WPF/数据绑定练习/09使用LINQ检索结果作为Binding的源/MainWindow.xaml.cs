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
using System.Data;

namespace _09使用LINQ检索结果作为Binding的源
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
            List<Student> stuList=new List<Student>()
                {
                    new Student(){Id = 0,Name = "Tim",Age=10},
                    new Student(){Id = 1,Name = "Tom",Age = 11},
                    new Student(){Id = 2,Name = "Tony",Age = 12},
                    new Student(){Id = 3,Name = "Jim",Age = 13}
                };
            this.listViewStudents.ItemsSource = from student in stuList
                                                where student.Name.StartsWith("T")
                                                select student;

        }
    }
}
