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
using System.Xml;

namespace _08使用XML数据作为Binding的源
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            XmlDocument doc=new XmlDocument();
            doc.Load(@"./StudentsData.xml");
            XmlDataProvider xdp=new XmlDataProvider();
            xdp.Document = doc;
            xdp.XPath = @"/StudentList/Student";

            this.listViewTest.DataContext = xdp;
            this.listViewTest.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
            XmlDataProvider xdp=new XmlDataProvider();
            xdp.Source = new Uri ( @"E:\C#\WPF\数据绑定练习\08使用XML数据作为Binding的源\bin\Debug\StudentsData.xml" );
            xdp.XPath = @"/StudentList/Student";

            this.listViewTest.DataContext = xdp;
            this.listViewTest.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
