using System;

namespace Venhicles
{
    class Car : IDriveable
    {
        public double Fuel { get ; set ; }
        public double Consuption { get ; set ; }
        public double Capacity { get ; set ; }

        public Car(double fuel, double consuption, double capacity)
        {
            if (fuel > capacity)
            {
                fuel = 0;
            }
            Fuel = fuel;
            Capacity = capacity;
            Consuption = consuption + 0.9;
        }

        public void Drive(double distance)
        {
            if (distance*Consuption<=Fuel)
            {
                Fuel -= distance * Consuption;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double fuel)
        {
            if (fuel > Capacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            Fuel += fuel;
        }
    }
}
