using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] name = Console.ReadLine().Split();
                string[] dough = Console.ReadLine().Split();
                string[] topping = Console.ReadLine().Split();
                List<Topping> topps = new List<Topping>();
                while (topping[0] != "END")
                {
                    topps.Add(new Topping(topping[1], decimal.Parse(topping[2])));
                    topping = Console.ReadLine().Split();
                }
                Pizza pizza = new 
                    Pizza(name[1], topps, new Dough(dough[1], dough[2], decimal.Parse(dough[3])));
                Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
