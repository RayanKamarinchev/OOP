using System;

namespace ClassBoxData
{
    class Box
    {
        private decimal lenght;
        private decimal weight;
        private decimal height;

        public decimal Lenght { get => lenght; set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                lenght = value; 
            } }
        public decimal Weight { get => weight; set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                weight = value; 
            } }
        public decimal Height { get => height; set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            } }

        public Box(decimal lenght, decimal weight, decimal height)
        {
            Lenght = lenght;
            Weight = weight;
            Height = height;
        }

        public decimal SurfaceArea()
        {
            return LateralArea() + Lenght * Weight * 2;
        }
        
        public decimal LateralArea()
        {
            return Height * (Lenght + Weight) * 2;
        }

        public decimal Volume()
        {
            return Lenght * Weight * Height;
        }
    }
}
