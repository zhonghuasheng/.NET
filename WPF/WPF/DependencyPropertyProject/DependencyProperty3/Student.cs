using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace DependencyProperty3
{
    class Student:DependencyObject
    {
        //依赖属性
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof (string),
                                                                                             typeof (Student));
        //CLR属性包装器
        public string Name
        {
            get { return (string) GetValue(NameProperty); }
            set{SetValue(NameProperty,value);}
        }
        
        //SetBinding包装
        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }

    }
}
