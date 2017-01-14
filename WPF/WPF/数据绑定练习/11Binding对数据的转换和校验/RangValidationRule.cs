using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace _11Binding对数据的转换和校验
{
    public class RangValidationRule:ValidationRule
    {
        public override ValidationResult Validate ( object value, System.Globalization.CultureInfo cultureInfo )
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true,null);
                }
            }
            return new ValidationResult(false,"Validation Failed");
        }
    }
}
