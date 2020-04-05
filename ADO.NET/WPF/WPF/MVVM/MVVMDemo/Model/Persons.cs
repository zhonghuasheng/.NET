using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMDemo.Model
{
    public class Persons
    {
        List<Person> personList = new List<Person>();
 
        public Persons()
        {
            personList.Add(new Person("Cassie",23));
            personList.Add(new Person("Luke",24));
            personList.Add(new Person("Lwies",24));
            personList.Add(new Person("Curt",23));
        }

        public List<Person> GetPersons()
        {
            return personList;
        }
    }
}
