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

namespace _02自定义路由事件
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
    }

    public abstract  class ButtonBase:ContentControl,ICommandSource
    {
        //声明并注册路由事件
        public static readonly RoutedEvent MyClickEvent=EventManager.RegisterRoutedEvent("MyClick",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(ButtonBase));

        //为路由时间添加CLR事件包装器
        public event RoutedEventHandler MyClick
        {
            add{this.AddHandler(MyClickEvent,value);}
            remove{this.RemoveHandler(MyClickEvent,value);}
        }

        //激发路由事件的方法。此方法在用户单击鼠标时会被Windows系统调用
        protected virtual void OnClick()
        {
            RoutedEventArgs newEvent=new RoutedEventArgs(ButtonBase.MyClickEvent,this);
        }

        //public abstract ICommand Command { get; }
        //public abstract object CommandParameter { get; }
        //public abstract IInputElement CommandTarget { get; }
    }
}
