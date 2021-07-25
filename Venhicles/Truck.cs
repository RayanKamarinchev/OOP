using System;

namespace Venhicles
{
    class Truck : IDriveable
    {
        public double Fuel { get; set; }
        public double Consuption { get; set; }
        public double Capacity { get ; set ; }

        public Truck(double fuel, double consuption, double capacity)
        {
            if (fuel>capacity)
            {
                fuel = 0;
            }
            Fuel = fuel;
            Capacity = capacity;
            Consuption = consuption + 1.6;
        }

        public void Drive(double distance)
        {
            if (distance * Consuption <= Fuel)
            {
                Fuel -= distance * Consuption;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
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
            Fuel += fuel * 0.95;
        }
    }
}
