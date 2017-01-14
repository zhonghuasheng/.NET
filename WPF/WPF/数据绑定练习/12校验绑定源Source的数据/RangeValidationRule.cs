using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;


namespace _12校验绑定源Source的数据
{
    class RangeValidationRule:ValidationRule
    {
        //需要实现Validate方法
        public override ValidationResult Validate ( object value, System.Globalization.CultureInfo cultureInfo )
        {
            double d = 0;
            if (value != null && double.TryParse(value.ToString(), out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true,null);
                }
            }
            return new ValidationResult(false, "Validation Failed");
        }
    }
}
