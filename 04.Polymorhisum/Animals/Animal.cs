namespace Animals_Polymorphisum
{
    class Animal
    {
        public string Name { get; set; }
        public string FavFood { get; set; }

        public Animal(string name, string favFood)
        {
            Name = name;
            FavFood = favFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavFood}";
        }
    }
}
