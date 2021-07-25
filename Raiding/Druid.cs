namespace Raiding
{
    class Druid : BaseHero
    {
        public Druid(string name)
            :base(name)
        {
            power = 80;
        }

        public override string CastAbility()
        {
            return $"Druid - {Name} healed for {power}";
        }
    }
}
