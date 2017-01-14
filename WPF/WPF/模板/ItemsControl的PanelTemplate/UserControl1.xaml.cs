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

namespace ItemsControl的PanelTemplate
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1 ( )
        {
            InitializeComponent ( );
        }

        //定义焦点变量
        private bool jiaodian;

        //定义一个字段存放图标的图片
        private ImageSource tubiao;

        //定义两个字段存放鼠标进入和离开（按下）时的图片
        private ImageSource jinru;
        private ImageSource likai;

        // 按钮的文本标题各项字段
        private string biaoti;
        private FontFamily textFamily;  //字体
        private double textSize;     //大小
        private Brush textColor;     //颜色
        private Thickness weizhi; //定义一个位置属性，这个不好用，目前没用。

        //委托和事件声明，这样你就能在自定义控件的事件列表里看到这个Dianji事件，可以在这个事件中写按钮点击的代码
        public delegate void pic2dianji ( object sender, EventArgs e );
        public event pic2dianji Dianji;

        //设计属性前面加Z是为了用控件时容易找到这个属性，一般会排到属性列表的最后
        //选择图标的图片
        public ImageSource Ztubiao
        {
            get { return tubiao; }
            set
            {
                tubiao = value;
                Tubiao.Source = tubiao;  //有这句在设计状态下会看到控件的变化,加载图标文件
            }
        }

        //选择鼠标进入时的图片
        public ImageSource Zjinru
        {
            get { return jinru; }
            set
            {
                jinru = value;
                Tupian.Source = jinru;   //image控件加载进入时的图片
            }
        }

        //选择鼠标离开或按下时的图片
        public ImageSource Zlikai
        {
            get { return likai; }
            set
            {
                likai = value;
                Tupian.Source = likai;   //image控件加载离开时的图片
            }
        }

        //输入按钮的标题内容
        public string Zbiaoti
        {
            get { return biaoti; }
            set
            {
                biaoti = value;
                Biaoti.Text = biaoti;  //textblock控件显示输入内容
            }
        }

        //设置标题文字的字体
        public FontFamily ZtextFamily
        {
            get { return textFamily; }
            set
            {
                textFamily = value;
                Biaoti.FontFamily = textFamily;  //实时改变字体
            }
        }

        // 设置标题字号
        public double ZtextSize
        {
            get { return textSize; }
            set
            {
                textSize = value;
                Biaoti.FontSize = textSize; //实时改变字号
            }
        }

        // 标题文字颜色
        public Brush ZtextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                Biaoti.Foreground = textColor; //实时改变文字颜色
            }
        }


        //控件加载时
        private void UserControl_Loaded ( object sender, RoutedEventArgs e )
        {
            Tubiao.Margin = new Thickness ( 3 );
            Tupian.Source = null;
        }

        private void UserControl_MouseEnter ( object sender, MouseEventArgs e )
        {
            //Tubiao.Margin = new Thickness(0);
            //Tupian.Source = jinru;
        }

        private void UserControl_MouseLeave ( object sender, MouseEventArgs e )
        {
            Tubiao.Margin = new Thickness ( 3 );
            Tupian.Source = null;
        }

        private void UserControl_MouseDown ( object sender, MouseButtonEventArgs e )
        {
            Tubiao.Margin = new Thickness ( 3 );
            Tupian.Source = likai;
        }

        private void Grid_MouseEnter ( object sender, MouseEventArgs e )
        {
            Tubiao.Margin = new Thickness ( 0 );
            Tupian.Source = jinru;
        }

        private void UserControl_MouseLeftButtonDown ( object sender, MouseButtonEventArgs e )
        {
            //Tubiao.Margin = new Thickness(0);
            //Tupian.Source = likai;
        }
    }
}
