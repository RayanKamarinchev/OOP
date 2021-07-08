using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        public virtual int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
