using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            if (name==null||name==" "||name=="")
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            if (age>MaxAge||age<MinAge)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }
            this.name = name;
            this.age = age;
        }

        private double CalculateProductPerDay()
        {
            switch (this.age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }

        public string ProductPerDay()
        {
            return $"Chicken {name} (age {age}) can produce {CalculateProductPerDay()} eggs per day.";
        }
    }
}
