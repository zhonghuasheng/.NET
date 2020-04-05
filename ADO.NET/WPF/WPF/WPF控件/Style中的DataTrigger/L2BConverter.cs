using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Style中的DataTrigger
{
    class L2BConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int textLength = (int) value;
            return textLength > 6 ? true : false;
        }

        public object ConvertBack(object value, Type targerType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
