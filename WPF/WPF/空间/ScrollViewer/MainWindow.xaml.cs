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

namespace ScrollViewer
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

        private void LineUp ( object sender, RoutedEventArgs e )
        {
            scroller.LineUp ( );
        }
        private void LineDown ( object sender, RoutedEventArgs e )
        {
            scroller.LineDown ( );
        }
        private void PageUp ( object sender, RoutedEventArgs e )
        {
            scroller.PageUp ( );
        }
        private void PageDown ( object sender, RoutedEventArgs e )
        {
            scroller.PageDown ( );
        }
    }
}
