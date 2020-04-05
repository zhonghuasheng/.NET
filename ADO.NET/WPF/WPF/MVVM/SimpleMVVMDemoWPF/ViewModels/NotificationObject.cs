using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SimpleMVVMDemoWPF.ViewModels
{
    class NotificationObject:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyChanged)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs(propertyChanged));
            }
        }
    }
}
