namespace Military
{
    class Mission : IMission
    {
        public string Name { get; set; }
        public string State { get; set; }

        public Mission(string name, string state)
        {
            Name = name;
            State = state;
        }

        public void CompleteMission()
        {
            State = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {Name} State: {State}";
        }
    }
}
