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

namespace 多数据条件触发的MultiDataTrigger
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
            List<Student> stuList=new List<Student>()
                {
                    new Student(){ID = 1,Name = "One",Age = 1},
                    new Student(){ID = 2,Name = "Two",Age = 2},
                    new Student(){ID = 3,Name = "Three",Age = 3},
                    new Student(){ID = 2,Name = "Tom",Age = 4}
                };
            this.list.ItemsSource = stuList;
        }
    }
}
