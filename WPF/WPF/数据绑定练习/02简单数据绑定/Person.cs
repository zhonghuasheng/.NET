using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace _02简单数据绑定
{
    class Person:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _personName= string.Empty;

        public string PersonName 
        {
            get { return this._personName; }
            set { this._personName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this,new PropertyChangedEventArgs(PersonName));
                }
            }
        }
    }
}
