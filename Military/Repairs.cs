namespace Military
{
    class Repairs : IRepairs
    {
        public string Name { get; set; }
        public int Hours { get; set; }

        public Repairs(string name, int hours)
        {
            Name = name;
            Hours = hours;
        }

        public override string ToString()
        {
            return $"Part Name: {Name} Hours Worked: {Hours}";
        }
    }
}
