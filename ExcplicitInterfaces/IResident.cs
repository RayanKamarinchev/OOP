namespace ExcplicitInterfaces
{
    interface IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }
        string GetName();
    }
}
