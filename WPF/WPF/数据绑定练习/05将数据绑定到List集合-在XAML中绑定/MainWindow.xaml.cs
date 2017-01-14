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

namespace _05将数据绑定到List集合_在XAML中绑定
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public Data myData;
        private List<Student> studentsList; 
        public MainWindow ( )
        {
            InitializeComponent ( );
            myData=new Data();
            //准备数据源

            studentsList =new List<Student> ( )
            {
                new Student(){StudentNum = 001,StudentName  = "Apple",StudentAge = 12},
                new Student(){StudentNum = 002,StudentName = "Banana",StudentAge = 13},
                new Student(){StudentNum = 003,StudentName = "Cocoa",StudentAge = 14},
                new Student(){StudentNum = 004,StudentName = "Dog",StudentAge = 15},
                new Student(){StudentNum = 005,StudentName = "Func",StudentAge = 16},
                new Student(){StudentNum = 006,StudentName = "Great",StudentAge = 17}
            };
            myData.StudentsList = studentsList;
            this.DataContext = myData;
        }
    }
}
