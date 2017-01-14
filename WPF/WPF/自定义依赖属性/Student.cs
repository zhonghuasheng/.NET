using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace 自定义依赖属性
{
    public class Student:DependencyObject
    {
        public static readonly DependencyProperty NameProperty =  
        DependencyProperty.Register ( "Name",
        typeof ( string ),
        typeof ( Student ),
        new PropertyMetadata ( string.Empty ) );

        public string Name
        {
            get
            {
                return ( string ) this.GetValue ( NameProperty );
            }
            set
            {
                this.SetValue ( NameProperty, value );
            }
        }  

        
    }
}
