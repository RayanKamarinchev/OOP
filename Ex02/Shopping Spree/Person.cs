using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public List<Product> Bag
        {
            get { return bag; }
            set { bag = value; }
        }
        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
            }
        }
        public string Name
        {
            get { return name; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
            }
        }

        public Person(string name, decimal money)
            :this()
        {
            Name = name;
            Money = money;
        }

        public Person()
        {
            Bag = new List<Product>();
        }
    }
}
