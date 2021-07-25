namespace Raiding
{
    class Rogue : BaseHero
    {
        public Rogue(string name)
            : base(name)
        {
            power = 80;
        }

        public override string CastAbility()
        {
            return $"Rogue - {Name} hit for {power} damage";
        }
    }
}
