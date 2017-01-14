using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DependencyProject2
{
    class Student : DependencyObject
    {
        //最简单的依赖属性
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register ( "Name", typeof ( string ),
                                                                                             typeof ( Student ) );
    }
}

