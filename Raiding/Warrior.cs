namespace Raiding
{
    class Warrior : BaseHero
    {
        public Warrior(string name)
            : base(name)
        {
            power = 100;
        }

        public override string CastAbility()
        {
            return $"Warrior - {Name} hit for {power} damage";
        }
    }
}
