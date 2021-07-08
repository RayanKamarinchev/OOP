using System;

namespace PizzaCalories
{
    class Dough
    {
        private decimal baseMod = 2;
        private decimal flourMod;
        private decimal bakingMod;
        private string flour;
        private string baking;
        private decimal weight;

        public string Flour
        {
            get { return flour; }
            set { flour = value; }
        }
        public string Baking
        {
            get { return baking; }
            set { baking = value; }
        }
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public decimal Calories { get; }

        public Dough(string flour, string baking, decimal weight)
        {
            if (weight <= 0 || weight > 200)
            {
                throw new Exception("Dough weight should be in the range [1..200].");
            }
            switch (flour.ToLower())
            {
                case "white":
                    flourMod = 1.5M;
                    break;
                case "wholegrain":
                    flourMod = 1;
                    break;
                default:
                    throw new Exception("Invalid type of dough.");
            }
            switch (baking.ToLower())
            {
                case "crispy":
                    bakingMod = 0.9M;
                    break;
                case "chewy":
                    bakingMod = 1.1M;
                    break;
                case "homemade":
                    bakingMod = 1;
                    break;
                default:
                    throw new Exception("Invalid type of dough.");
            }
            Flour = flour;
            Baking = baking;
            Weight = weight;
            Calories = Weight * baseMod * flourMod * bakingMod;
        }
    }
}
