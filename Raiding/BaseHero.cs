namespace Raiding
{
    class BaseHero
    {
        public int power { get; set; }
        public string Name { get; set; }

        public BaseHero(string name)
        {
            Name = name;
        }

        public virtual string CastAbility() => "";
    }
}
