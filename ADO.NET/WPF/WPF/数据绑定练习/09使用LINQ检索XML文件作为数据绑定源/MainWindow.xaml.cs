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
using System.Xml.Linq;

namespace _09使用LINQ检索XML文件作为数据绑定源
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
            ///这种写法实现不了，原因估计是没能加载在XML文件
            //XmlDocument xdoc = new XmlDocument ( );
            //xdoc.Load ( @"./StudentsXmlData.xml" );
            //this.ListViewStudents.ItemsSource = xdoc.Descendants ( "Student" )
            //        .Where ( element => element.Attribute ( "Name" ).Value.StartsWith ( "T" ) )
            //        .Select ( element => new Student ( )
            //            {
            //                Id = int.Parse ( element.Attribute ( "Id" ).Value ),
            //                Name = element.Attribute ( "Name" ).Value,
            //                Age = int.Parse ( element.Attribute ( "Age" ).Value )
            //            } );

            XDocument xdoc = XDocument.Load ( @"./StudentsXmlData.xml" );
            this.ListViewStudents.ItemsSource =
                xdoc.Descendants ( "Student" )
                    .Where ( element => element.Attribute ( "Name" ).Value.StartsWith ( "T" ) )
                    .Select ( element => new Student ( )
                        {
                            Id = int.Parse ( element.Attribute ( "Id" ).Value ),
                            Name = element.Attribute ( "Name" ).Value,
                            Age = int.Parse ( element.Attribute ( "Age" ).Value )
                        } );

        }
    }
}
