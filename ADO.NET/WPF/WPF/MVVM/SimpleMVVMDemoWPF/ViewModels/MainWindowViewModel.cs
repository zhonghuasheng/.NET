using SimpleMVVMDemoWPF.Commannds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMVVMDemoWPF.ViewModels
{
    class MainWindowViewModel : NotificationObject
    {
        private double _input1;
        private double _input2;
        private double _result;

        public double Input1
        {
            get { return _input1; }
            set
            {
                _input1 = value;
                this.RaisePropertyChanged("Input1");
            }
        }

        public double Input2
        {
            get { return _input2; }
            set
            {
                _input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                this.RaisePropertyChanged("Result");
            }
        }

        public DelegateCommand AddCommand { get; set; }

        private void Add(object parameter)
        {
            this.Result = this.Input1 + this.Input2;
        }

        public MainWindowViewModel()
        {
            this.AddCommand = new DelegateCommand();
            this.AddCommand.ExecuteAction = new Action<object>(this.Add);
        }
    }
}
