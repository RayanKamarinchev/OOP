using System;

namespace Venhicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            string[] input3 = Console.ReadLine().Split();
            Car car = new Car(double.Parse(input1[1]), double.Parse(input1[2]), double.Parse(input1[3]));
            Truck truck = new Truck(double.Parse(input2[1]), double.Parse(input2[2]), double.Parse(input2[3]));
            Bus bus = new Bus(double.Parse(input3[1]), double.Parse(input3[2]), double.Parse(input3[3]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                try
                {
                    if (command[0] == "Drive")
                    {
                        if (command[1] == "Car")
                        {
                            car.Drive(double.Parse(command[2]));
                        }
                        else if (command[1] == "Truck")
                        {
                            truck.Drive(double.Parse(command[2]));
                        }
                        else
                        {
                            bus.Drive(double.Parse(command[2]));
                        }
                    }
                    else if (command[0] == "Refuel")
                    {
                        if (command[1] == "Car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }
                        else if (command[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }
                        else
                        {
                            bus.Refuel(double.Parse(command[2]));
                        }
                    }
                    else
                    {
                        bus.DriveEmpthy(double.Parse(command[2]));
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");
            Console.WriteLine($"Bus: {bus.Fuel:F2}");
        }
    }
}
