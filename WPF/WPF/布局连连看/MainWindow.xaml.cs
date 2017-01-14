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

namespace 布局连连看
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //添加行
            for (int i = 0; i < 10; i++)
            {
                RowDefinition row = new RowDefinition();
                myGrid.RowDefinitions.Add(row);
                ColumnDefinition column = new ColumnDefinition();
                myGrid.ColumnDefinitions.Add(column);
            }

        }
        
        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Button btn = new Button();
                    //btn.Content = i + "," + j;
                    ////设置元素的坐标位置
                    //Grid.SetRow(btn, i);
                    //Grid.SetColumn(btn, j);
                    //myGrid.Children.Add(btn);
                    int index = ran.Next(0,10);
                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri("/images/" + index + ".png",UriKind.Relative));
                    Grid.SetRow(img, i);
                    Grid.SetColumn(img, j);
                    myGrid.Children.Add(img);
                }
            }
        }
    }
}
