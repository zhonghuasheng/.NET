using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace _01_WPF_布局
{
    /// <summary>
    /// App.xaml 的交互逻辑-在这里我自定义程序启动页面
    /// </summary>

    public partial class App : Application
    {
        //[STAThread]
        //在这里定义Main方法
        //static void Main()
        //{
        //    定义一个Application对象作为程序的入口
        //    Application app = new Application();
        //    调用Run方法
        //    Window1 win1 = new Window1();
        //    app.Run(win1);
        //}
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("确认要关闭窗体吗？");
        }
    }
}
