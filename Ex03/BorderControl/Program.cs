using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Person> people = new List<Person>();
            List<Robot> robot = new List<Robot>();
            while (command[0]!="End")
            {
                if (command.Length==3)
                {
                    people.Add(new Person(command[0], int.Parse(command[1]), command[2]));
                }
                else
                {
                    robot.Add(new Robot(command[0], command[1]));
                }
                command = Console.ReadLine().Split();
            }

            string invalidNumber = Console.ReadLine();
            List<string> invalidNums = new List<string>();
            foreach (var item in people)
            {
                if (item.Id.EndsWith(invalidNumber))
                {
                    invalidNums.Add(item.Id);
                }
            }
            foreach (var item in robot)
            {
                if (item.Id.EndsWith(invalidNumber))
                {
                    invalidNums.Add(item.Id);
                }
            }
            foreach (var item in invalidNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
