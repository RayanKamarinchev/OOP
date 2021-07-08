using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Child : Person
    {
        public Child(string name, int age):
            base(name, age)
        {

        }

        public override int Age
        {
            get { return base.Age; }
            set
            {
                if (Age>15)
                {
                    throw new Exception("age cannot be more than 15");
                }
                base.Age = value;
            }
        }
    }
}
