using System;
using System.Collections.Generic;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command.Length==4)
                {
                    citizens.Add(new Citizen(command[0], int.Parse(command[1]), command[2], command[3]));
                }
                else
                {
                    rebels.Add(new Rebel(command[0], int.Parse(command[1]), command[2]));
                }
            }
            string name = Console.ReadLine();
            int purchasedFood = 0;
            while (name!="End")
            {
                foreach (var citizen in citizens)
                {
                    if (citizen.Name==name)
                    {
                        citizen.BuyFood();
                        purchasedFood += 10;
                    }
                }
                foreach (var rebel in rebels)
                {
                    if (rebel.Name==name)
                    {
                        rebel.BuyFood();
                        purchasedFood += 5;
                    }
                }
                name = Console.ReadLine();
            }
            Console.WriteLine(purchasedFood);
        }
    }
}
