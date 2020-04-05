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

namespace _04附加事件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
            //为外层Grid添加路由事件监听器
           // this.gridMain.AddHandler(Student.NameChangedEvent,new RoutedEventHandler(this.StudentNameChangedHandler));

            //修改：
            Student.AddNameChangedHandler(this.gridMain,new RoutedEventHandler(this.StudentNameChangedHandler));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu=new Student(){Id = 100,Name = "张三"};
            stu.Name = "李四";
            //准备事件消息并发送路由事件
            RoutedEventArgs arg=new RoutedEventArgs(Student.NameChangedEvent,stu);
            //引发特定的路由事件  Raise具有升起 发送的意思
            this.button1.RaiseEvent(arg);
        }

        //Grid捕捉到NameChangedEvent后的处理器
        private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).Name);
        }
    }
}
