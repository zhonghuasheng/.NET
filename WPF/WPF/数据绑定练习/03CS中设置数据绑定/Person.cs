using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace _03CS中设置数据绑定
{
    class Person:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;

        public string Name
        {
            get { return _name; }

            set 
            {
                _name = value;
                //激发事件
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs("Name"));
                }
            }
        }
    }
}
