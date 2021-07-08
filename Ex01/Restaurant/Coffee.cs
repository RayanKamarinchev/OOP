namespace Restaurant
{
    class Coffee : HotBeverage
    {
        double CoffeeMilliliters = 50;
        decimal CoffeePrice = 3.50M;
        public double Caffeine { get; set; }

        public Coffee(string name, decimal price, double mililiters, double caffeine)
            : base(name, price, mililiters)
        {
            Caffeine = caffeine;
        }
    }
}
