using System;

namespace ExcplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            while (command[0]!="End")
            {
                Citizen citizen = new Citizen(command[0], command[1], int.Parse(command[2]));
                Console.WriteLine(citizen.GetName());
                command = Console.ReadLine().Split();
            }
        }
    }
}
