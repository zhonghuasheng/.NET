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

namespace _03CS中设置数据绑定
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //#region 方法一

        //private Person per;

        //public MainWindow()
        //{
        //    InitializeComponent();
        //    //准备数据源
        //    per = new Person();
        //    //准备Binding
        //    Binding binding = new Binding();
        //    binding.Source = per;
        //    binding.Path = new PropertyPath("Name");
        //    //使用Binding连接数据源与Binding目标
        //    BindingOperations.SetBinding(this.TxtTest, TextBox.TextProperty, binding);

        //}

        //private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        //{
        //    per.Name += "name";

        //}

        //#endregion

        Person per;
        public MainWindow()
        {

            InitializeComponent();
            this.TxtTest.SetBinding(TextBox.TextProperty, new Binding("Name") {Source = per = new Person()});
        }

        public void BtnTest_OnClick(object sender, EventArgs e)
        {
            per.Name += "你好";
        }
    }
}
