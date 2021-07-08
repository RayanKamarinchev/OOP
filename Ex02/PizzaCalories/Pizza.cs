using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Pizza
    {
        public decimal Calories { get; private set; }
        public int Count { get; } = 0;
        public string Name { get; set; }
        public List<Topping> Toppings { get; set; }
        public Dough Dough { get; set; }

        public Pizza(string name, List<Topping> toppings, Dough dough)
        {
            if (name.Length<1||name.Length>15)
            {
                throw new Exception("Pizza name should be between 1 and 15 symbols.");
            }
            if (toppings.Count>10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            Name = name;
            Toppings = new List<Topping>(toppings);
            Dough = dough;
            Calories = Dough.Calories;
            foreach (var item in Toppings)
            {
                Calories += item.Calories;
            }
        }


    }
}
