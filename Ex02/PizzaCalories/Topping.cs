using System;

namespace PizzaCalories
{
    public class Topping
    {
        private decimal baseMod = 2;
        private decimal typeMod;
        private string type;
        private decimal weight;
        private decimal calories;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public decimal Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public Topping(string type, decimal weight)
        {
            switch (type.ToLower())
            {
                case "meat":
                    typeMod = 1.2M;
                    break;
                case "veggies":
                    typeMod = 0.8M;
                    break;
                case "cheese":
                    typeMod = 1.1M;
                    break;
                case "sauce":
                    typeMod = 0.9M;
                    break;
                default:
                    throw new Exception($"Cannot place {type} on top of your pizza.");
            }
            if (weight <= 0 || weight > 50)
            {
                throw new Exception($"{type} weight should be in the range [1..50].");
            }
            Type = type;
            Weight = weight;
            Calories = baseMod * Weight * typeMod;
        }
    }
}
