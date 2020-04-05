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

namespace 依赖属性的默认值
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
            MainWindow main=new MainWindow ( );
            txtTest1.Text = main.Num.ToString ( );

            MainWindow main2=new MainWindow();
            main2.Num = 3.4;
            txtTest2.Text = main2.GetValue(NumProperty).ToString();
        }

        public static readonly DependencyProperty NumProperty = DependencyProperty.Register("Num", typeof (double),
                                                                                            typeof (MainWindow),
                                                                                            new PropertyMetadata ( 8.0 ), new ValidateValueCallback ( IsSize ) );

        public double Num
        {
            get { return (double) this.GetValue(NumProperty); }
            set{this.SetValue(NumProperty,value);}
        }

        public static bool IsSize(object obj)
        {
            double numtest = (double) obj;
            return numtest > 7; 
        }

        public void ChangeNum(DependencyObject dp,object obj)
        {
            MainWindow main = dp as MainWindow;
            double numtest = (double) obj;
            if (numtest < 8) main.Num = 8;
        }
    }
}
