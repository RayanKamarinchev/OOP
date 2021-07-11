namespace BorderControl
{
    class Person : IHaveId
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get ; set ; }

        public Person(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
