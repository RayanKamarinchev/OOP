using System;

namespace PhonesSoftware
{
    class StationaryPhone : ICanCall
    {
        public string Number { get; set; }
        public virtual void Call()
        {
            Console.WriteLine($"Dialing... {Number}");
        }
    }
}
