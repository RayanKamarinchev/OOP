﻿namespace Military
{
    class Soldier : ISoldier
    {
        public string Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }

        public Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
