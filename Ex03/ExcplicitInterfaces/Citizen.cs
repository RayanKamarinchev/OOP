using System.Text;

namespace ExcplicitInterfaces
{
    class Citizen : IPerson, IResident
    {
        public string Name { get ; set ; }
        public string Country { get ; set ; }
        public int Age { get ; set ; }

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string GetName()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}");
            sb.AppendLine($"Mr/Ms/Mrs {Name}");
            return sb.ToString().TrimEnd();
        }
    }
}
