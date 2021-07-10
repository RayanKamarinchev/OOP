namespace Military
{
    class SpecialisedSoldier : Private, ISpecialSolider
    {
        public string Corps { get; set; }

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }
    }
}
