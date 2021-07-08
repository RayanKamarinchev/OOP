namespace Cars
{
    abstract class Car : ICar
    {
        public abstract string Model { get; set; }
        public abstract string Color { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}
