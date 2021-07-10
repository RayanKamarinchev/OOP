using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; set; }

        public Commando(string id, string firstName, string lastName, decimal salary, string corps
            , List<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Missions:");
            foreach (var mission in Missions)
            {
                sb.AppendLine(mission.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
