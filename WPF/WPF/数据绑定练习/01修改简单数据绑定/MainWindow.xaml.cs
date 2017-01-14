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

namespace _01修改简单数据绑定
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Data data;
        private List<Person> personList; 
        public MainWindow ( )
        {
            InitializeComponent ( );
            personList=new List<Person>()
                {
                    new Person(){Name = "张三"},
                    new Person(){Name = "李四"},
                    new Person(){Name = "王五"}
                };
            data=new Data();
            data.PersonList = personList;
            this.DataContext = data;
        }
    }
}
