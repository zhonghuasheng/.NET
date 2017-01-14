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
using System.Threading;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace PanelDemo.Controls
{
    /// <summary>
    /// MenuControl.xaml 的交互逻辑
    /// </summary>
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            InitTimer();
            ShowMessage("你好，吃货！");
            InitEvent();
        }

        private void InitTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += delegate(object sender, EventArgs e)
            {
                this.CurrentDate.Text = DateTime.Now.ToString();
            };
            timer.IsEnabled = true;
        }

        private void ShowMessage(string message)
        {
            this.MessageBlock.Text = message;
        }

        private void InitEvent()
        {
            //当鼠标进入时消息框隐藏
            this.MouseEnter += delegate(object sender, MouseEventArgs e)
            {
                this.MessagePanel.Visibility = System.Windows.Visibility.Hidden;
            };

            //当动画结束是消息框显示，这里不是鼠标离开，可以试试看体验效果
            Storyboard storyboard = this.Resources["St_RootGridMouseLeave"] as Storyboard;
            storyboard.Completed += delegate(object sender, EventArgs e)
            {
                this.MessagePanel.Visibility = System.Windows.Visibility.Visible;
            };
        }

        
    }
}
