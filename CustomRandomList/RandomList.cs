using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public Random rnd { get; set; }

        public string RandomString()
        {
            int index = rnd.Next(0, this.Count);
            string result = this[index];
            this.RemoveAt(index);
            return result;
        }
    }
}
