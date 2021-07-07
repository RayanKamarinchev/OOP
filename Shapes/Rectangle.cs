using System;

namespace Shapes
{
    class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height-1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int width, char v1, char v2)
        {
            Console.Write(v1);
            for (int i = 1; i < Height-1; ++i)
            {
                Console.Write(v2);
            }
            Console.WriteLine(v1);
        }
    }
}
