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

namespace _10ObjectDataProvider在XAML中的使用
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
            this.SetBinding();
        }

        private void SetBinding()
        {
            //创建并配置ObjectDataProvider对象
            ObjectDataProvider odp=new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("10");
            odp.MethodParameters.Add("10");

            //以ObjectDataProvider对象为Source创建Binding
            Binding bindingToStr1=new Binding("MethodParameters[0]")
                {
                    Source = odp,
                    BindsDirectlyToSource=true,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };

            Binding bindingToStr2=new Binding("MethodParameters[1]")
                {
                    Source = odp,
                    BindsDirectlyToSource = true,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };

            Binding bindingToResult=new Binding("."){Source = odp};

            //将Binding关联到UI元素上
            this.TextBoxStr1.SetBinding(TextBox.TextProperty, bindingToStr1);
            this.TextBoxStr2.SetBinding(TextBox.TextProperty, bindingToStr2);
            this.TextBoxResult.SetBinding(TextBox.TextProperty, bindingToResult);
        }
    }
}
