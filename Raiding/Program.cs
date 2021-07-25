using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> group = new List<BaseHero>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Paladin":
                        group.Add(new Paladin(name));
                        break;
                    case "Druid":
                        group.Add(new Druid(name));
                        break;
                    case "Warrior":
                        group.Add(new Warrior(name));
                        break;
                    case "Rogue":
                        group.Add(new Rogue(name));
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        i--;
                        break;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            int groupPower = 0;
            foreach (var hero in group)
            {
                groupPower += hero.power;
                Console.WriteLine(hero.CastAbility());
            }
            if (groupPower>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
