using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter()
        {
            return (Height + Width) * 2;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height - 1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int width, char v1, char v2)
        {
            Console.Write(v1);
            for (int i = 1; i < Height - 1; ++i)
            {
                Console.Write(v2);
            }
            Console.WriteLine(v1);
        }
    }
}
