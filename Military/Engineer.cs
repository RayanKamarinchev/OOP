using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repairs> Repairs { get; set; }

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps
            , List<Repairs> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine(repair.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
