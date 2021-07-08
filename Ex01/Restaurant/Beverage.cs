namespace Restaurant
{
    class Beverage : Product
    {
        public double Milliliters { get; set; }
        public Beverage(string name, decimal price, double mililiters)
            : base(name, price)
        {
            Milliliters = mililiters;
        }
    }
}
