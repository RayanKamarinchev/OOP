using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> outputPeople = Console.ReadLine()
                .Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> outputProducts = Console.ReadLine()
                    .Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();
                for (int i = 0; i < outputPeople.Count; i += 2)
                {
                    people.Add(new Person(outputPeople[i], decimal.Parse(outputPeople[i + 1])));
                }
                for (int i = 0; i < outputProducts.Count; i += 2)
                {
                    products.Add(new Product(outputProducts[i], decimal.Parse(outputProducts[i + 1])));
                }

                string[] command = Console.ReadLine().Split();
                while (command[0] != "END")
                {
                    Person buyer = new Person();
                    Product item = new Product();
                    foreach (var person in people)
                    {
                        if (person.Name == command[0])
                        {
                            buyer = person;
                            break;
                        }
                    }
                    foreach (var product in products)
                    {
                        if (product.Name == command[1])
                        {
                            item = product;
                            break;
                        }
                    }
                    if (buyer.Money >= item.Cost)
                    {
                        buyer.Money -= item.Cost;
                        buyer.Bag.Add(item);
                        Console.WriteLine($"{buyer.Name} bought {item.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{buyer.Name} can't afford {item.Name}");
                    }
                    command = Console.ReadLine().Split();
                }
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Bag.Count==0)
                    {
                        Console.WriteLine("Nothing bought");
                    }
                    else
                    {
                        string[] unRawItems = new string[people[i].Bag.Count];
                        for (int j = 0; j < people[i].Bag.Count; j++)
                        {
                            string name = people[i].Bag[j].Name;
                            unRawItems[j]=name;
                        }
                        Console.WriteLine($"{people[i].Name} - {string.Join(", ", unRawItems)}");
                    }
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }
    }
}
