using System;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal a = decimal.Parse(Console.ReadLine());
                decimal b = decimal.Parse(Console.ReadLine());
                decimal c = decimal.Parse(Console.ReadLine());
                Box box = new Box(a, b, c);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralArea():F2}");
                Console.WriteLine($"Volume - {box.Volume():F2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
