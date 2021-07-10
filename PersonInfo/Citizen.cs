namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable, IBuyer
    {
        public string Name { get ; set ; }
        public int Age { get ; set ; }
        public string Id { get ; set ; }
        public string Birthdate { get ; set ; }
        public int Food { get ; set ; }

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthday;
            Food = 0;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
