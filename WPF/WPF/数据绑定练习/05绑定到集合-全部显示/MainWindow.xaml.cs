using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _05绑定到集合_全部显示
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> stuList;
        private ObservableCollection<Student> newStuList;
        public MainWindow ( )
        {
            InitializeComponent ( );
            stuList=new List<Student>()
                {
                    new Student(){StudentId = 001,StudentName = "张三",StudentAge = 12},
                    new Student(){StudentId = 002,StudentName = "李四",StudentAge = 13},
                    new Student(){StudentId = 003,StudentName = "王五",StudentAge = 14},
                    new Student(){StudentId = 004,StudentName = "赵六",StudentAge = 15},
                    new Student(){StudentId = 005,StudentName = "陈七",StudentAge = 16}
                };

            newStuList=new ObservableCollection<Student>()
                {
                    new Student(){StudentId = 001,StudentName = "张三",StudentAge = 12},
                    new Student(){StudentId = 002,StudentName = "李四",StudentAge = 13},
                    new Student(){StudentId = 003,StudentName = "王五",StudentAge = 14},
                    new Student(){StudentId = 004,StudentName = "赵六",StudentAge = 15},
                    new Student(){StudentId = 005,StudentName = "陈七",StudentAge = 16}
                };

            this.listBoxStudents.ItemsSource = newStuList;
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
            newStuList.Add(new Student(){StudentId = 006,StudentName = "新添加的",StudentAge = 17});

        }
    }
}
