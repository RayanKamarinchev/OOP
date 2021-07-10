using System;

namespace PhonesSoftware
{
    class Smartphone : StationaryPhone, IBrowsing
    {
        public string Site { get; set; }

        public void Browse()
        {
            Console.WriteLine($"Browsing: {Site}!");
        }

        public override void Call()
        {
            Console.WriteLine($"Calling... {Number}");
        }
    }
}
