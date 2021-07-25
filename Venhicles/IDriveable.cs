namespace Venhicles
{
    interface IDriveable
    {
        public double Fuel { get; set; }
        public double Consuption { get; set; }
        public double Capacity { get; set; }

        void Drive(double distance);
        void Refuel(double fuel);
    }
}
