namespace Raiding
{
    class Paladin : BaseHero
    {
        public Paladin(string name)
            : base(name)
        {
            power = 100;
        }

        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {power}";
        }
    }
}
