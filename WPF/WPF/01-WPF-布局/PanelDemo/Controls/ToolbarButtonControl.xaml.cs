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

namespace PanelDemo.Controls
{
    /// <summary>
    /// ToolbarButtonControl.xaml 的交互逻辑
    /// </summary>
    public partial class ToolbarButtonControl : UserControl
    {
        public ToolbarButtonControl()
        {
            InitializeComponent();
        }

        public Brush FillColor
        {
            get { return this.RectangleObject.Fill; }
            set { this.RectangleObject.Fill = value; }
        }

        public string Text
        {
            get { return this.TextBlockObject.Text; }
            set { this.TextBlockObject.Text = value; }
        }

        public Brush TextBloclColor
        {
            get { return this.TextBlockObject.Foreground; }
            set { this.TextBlockObject.Foreground = value; }
        }
    }
}
