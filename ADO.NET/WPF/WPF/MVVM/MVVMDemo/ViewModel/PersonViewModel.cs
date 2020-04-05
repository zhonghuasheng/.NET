using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MVVMDemo.Model;

namespace MVVMDemo.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("SearchText"));
                }
            }
        }

        private List<Person> _resutlText;
        public List<Person> ResultText
        {
            get { return _resutlText; }
            set
            {
                _resutlText = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,new PropertyChangedEventArgs("ResultText"));
                }
            }
        }

        private ICommand _cmd;
        public ICommand Cmd
        {
            get { return _cmd; }
        }

        public List<Person> Human; 
        public PersonViewModel()
        {
            Human = new List<Person>();
            Human = new Persons().GetPersons();
            //_cmd = new Relay
        }

        public void Searching()
        {
            List<Person> person = null;
            if (!string.IsNullOrEmpty(SearchText))
            {
                person = new List<Person>();
                foreach (Person p in Human)
                {
                    if (p.Name.Contains(SearchText))
                    {
                        person.Add(p);
                    }
                    if (person != null)
                    {
                        ResultText = person;
                    }
                }
            }
        }
    }
}
