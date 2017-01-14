using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _04附加事件
{
    class Student
    {
        //声明并定义路由事件
        public static readonly RoutedEvent NameChangedEvent=EventManager.RegisterRoutedEvent ( "NameChanged", RoutingStrategy.Bubble, typeof ( RoutedEventHandler ), typeof ( Student ) );

        //为界面元素添加路由事件侦听
        public static void AddNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.AddHandler(Student.NameChangedEvent,h);
            }
        }

        //移除侦听
        public static void RemoveNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.RemoveHandler(Student.NameChangedEvent,h);
            }
        }

        //声明两个属性
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
