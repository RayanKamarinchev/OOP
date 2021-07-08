namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        public override double FuelConsumption { get => 8; set => base.FuelConsumption = value; }
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
    }
}
