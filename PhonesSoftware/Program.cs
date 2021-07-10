using System;

namespace PhonesSoftware
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();
            StationaryPhone statPhone = new StationaryPhone();
            Smartphone smart = new Smartphone();
            foreach (var number in numbers)
            {
                if (ValidNumber(number))
                {
                    if (number.Length==10)
                    {
                        smart.Number = number;
                        smart.Call();
                    }
                    else
                    {
                        statPhone.Number = number;
                        statPhone.Call();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            foreach (var site in sites)
            {
                if (ValidSite(site))
                {
                    smart.Site = site;
                    smart.Browse();
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }

        static bool ValidNumber(string number)
        {
            bool valid = true;
            foreach (var item in number)
            {
                if (!Char.IsDigit(item))
                {
                    valid = false;
                }
            }
            return valid;
        }

        static bool ValidSite(string site)
        {
            bool valid = true;
            foreach (var item in site)
            {
                if (Char.IsDigit(item))
                {
                    valid = false;
                }
            }
            return valid;
        }
    }
}
