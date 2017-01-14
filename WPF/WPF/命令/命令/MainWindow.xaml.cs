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

namespace 命令
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
            InitializeCommand();
        }

        //声明并定义命令
        private RoutedCommand clearCmd=new RoutedCommand("Clear",typeof(MainWindow));

        private void InitializeCommand()
        {
            //把命令赋值给命令源（发送者）并指定快捷键
            this.button1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));//设置快捷键

            //指定命令目标
            this.button1.CommandTarget = this.textBoxA;

            //创建命令关联
            CommandBinding cb=new CommandBinding();
            cb.Command = this.clearCmd;
            cb.CanExecute+=new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed+=new ExecutedRoutedEventHandler(cb_Executed);

            //把命令关联安置在外围控件上
            this.stackPanel1.CommandBindings.Add(cb);
        }

        //当探测命令是否可以执行时，此方法被调用
        void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxA.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }

            //避免继续向上传而降低程序性能
            e.Handled = true;
        }

        //当命令送达目标后，此方法被调用
        void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBoxA.Clear();

            //避免继续向上传而降低程序性能
            e.Handled = true;
        }
    }
}
