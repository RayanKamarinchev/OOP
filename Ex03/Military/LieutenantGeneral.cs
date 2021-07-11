using System.Collections.Generic;
using System.Text;

namespace Military
{
    class LieutenantGeneral : Private, ILientenantGeneral
    {
        public List<Private> Privates { get; set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary
            , List<Private> privates)
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<Private>(privates);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");
            foreach (var priv in Privates)
            {
                sb.AppendLine(priv.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
