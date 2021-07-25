using System;

namespace Venhicles
{
    class Bus : IDriveable
    {
        public double Fuel { get ; set ; }
        public double Consuption { get ; set ; }
        public double Capacity { get ; set ; }

        public Bus(double fuel, double consuption, double capacity)
        {
            if (fuel>capacity)
            {
                fuel = 0;
            }
            Fuel = fuel;
            Consuption = consuption + 1.4;
            Capacity = capacity;
        }

        public void Drive(double distance)
        {
            if (distance * Consuption <= Fuel)
            {
                Fuel -= distance * Consuption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpthy(double distance)
        {
            Consuption -= 1.4;
            Drive(distance);
            Consuption += 1.4;
        }

        public void Refuel(double fuel)
        {
            if (fuel>Capacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            if (fuel<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            Fuel += fuel;
        }
    }
}
