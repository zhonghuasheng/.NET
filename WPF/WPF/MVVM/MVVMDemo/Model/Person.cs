using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMDemo.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
