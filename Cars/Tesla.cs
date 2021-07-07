using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : Car, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public int Battery { get ; set ; }
        public override string Model { get ; set ; }
        public override string Color { get ; set ; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
            return sb.ToString().TrimEnd();
        }
    }
}
