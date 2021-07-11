namespace ExcplicitInterfaces
{
    interface IPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }
        string GetName();
    }
}
