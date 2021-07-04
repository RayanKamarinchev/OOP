namespace NeedForSpeed
{
    class SportCar : Car
    {
        public override double FuelConsumption { get => 10; set => base.FuelConsumption = value; }
        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
    }
}
