using System;

namespace Animals_Polymorphisum
{
    class Dog : Animal
    {
        public Dog(string v1, string v2)
            :base(v1, v2)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }
    }
}
