using System.Text;

namespace Military
{
    class Spy : Soldier, ISpy
    {
        public int Code { get; set; }

        public Spy(string id, string firstName, string lastName, int code)
            : base(id, firstName, lastName)
        {
            Code = code;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {Code}");
            return sb.ToString().TrimEnd();
        }
    }
}
