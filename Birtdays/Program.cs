using System;
using System.Collections.Generic;

namespace Birtdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<string[]> birthdays = new List<string[]>();
            while (command[0]!="End")
            {
                birthdays.Add(command[command.Length - 1].Split('/'));
                command = Console.ReadLine().Split();
            }
            string year = Console.ReadLine();
            foreach (var item in birthdays)
            {
                if (item[item.Length-1]==year)
                {
                    Console.WriteLine(string.Join("/", item));
                }
            }
        }
    }
}
