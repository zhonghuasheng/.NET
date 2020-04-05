using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace 自定义属性
{
    class Student:DependencyObject
    {
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name",typeof(string),typeof(Student));

        //键入propdp，按两下Tab键
        public string Age
        {
            get 
            {
                return(string)GetValue(AgeProperty);
            }

            set
            { 
                SetValue(AgeProperty, value); 
            }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(string), typeof(Student));
        //SetBinding包装，模拟实现SetValue功能
        public BindingExpressionBase SetBinding(DependencyProperty dp, Binding binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
        
    }
}
