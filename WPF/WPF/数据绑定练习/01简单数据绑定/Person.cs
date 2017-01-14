using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace _01简单数据绑定
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        //1、该接口就只有一个事件PropertyChanged定义
        public event PropertyChangedEventHandler PropertyChanged;
        //public   event PropertyChangedEventHandler   PropertyChanged;
        protected void Notify(string personName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(personName));
            }
        }
        ////4、Notify方法

        //protected void Notify ( string propName )
        //{

        //    if ( PropertyChanged != null )
        //    {

        //        PropertyChanged ( this, new PropertyChangedEventArgs ( propName ) );

        //    }

        //}
    }
}
