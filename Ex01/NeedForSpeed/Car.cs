namespace NeedForSpeed
{
    class Car : Vehicle
    {
        public override double FuelConsumption { get => 3; set => base.FuelConsumption = value; }
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
    }
}
