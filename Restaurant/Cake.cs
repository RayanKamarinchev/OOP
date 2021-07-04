using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake : Dessert
    {
        private const double defGrams = 250;
        private const double defCalories = 1000;
        private const decimal defPrice = 5;
        public Cake(string name)
            : base(name, defPrice, defGrams, defCalories)
        {
        }
    }
}
