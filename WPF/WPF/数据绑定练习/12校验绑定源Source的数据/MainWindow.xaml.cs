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

namespace _12校验绑定源Source的数据
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( )
        {
            InitializeComponent ( );

            Binding binding=new Binding("Value"){Source = this.sliTest};
            binding.UpdateSourceTrigger=UpdateSourceTrigger.PropertyChanged;
            RangeValidationRule rvr = new RangeValidationRule();
            rvr.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rvr);
            binding.NotifyOnValidationError = true;
            this.txtTest.SetBinding(TextBox.TextProperty, binding);
            //侦听
            this.txtTest.AddHandler(Validation.ErrorEvent,new RoutedEventHandler(this.ValidationError));
        }

        void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(this.txtTest).Count > 0)
            {
                this.txtTest.ToolTip = Validation.GetErrors(this.txtTest)[0].ErrorContent.ToString();
            }
        }
    }
}
