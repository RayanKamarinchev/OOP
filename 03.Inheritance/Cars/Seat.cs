using System.Text;

namespace Cars
{
    class Seat : Car
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string Model { get; set ; }
        public override string Color { get; set ; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            sb.AppendLine($"{Color} Seat {Model}");
            return sb.ToString().TrimEnd();
        }
    }
}
