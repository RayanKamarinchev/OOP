using System;

namespace FootballTeam
{
    class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (value==null||value==" "||value=="")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value; 
            }
        }
        private int endurance;

        public int Endurance
        {
            get { return endurance; }
            set 
            {
                if (value>100||value<0)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }
                endurance = value; 
            }
        }
        private int sprint;

        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        private int dribble;

        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }
                dribble = value;
            }
        }
        private int passing;

        public int Passing
        {
            get { return passing; }
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }
                passing = value;
            }
        }
        private int shooting;

        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }
                shooting = value;
            }
        }
        private double averageSkill;

        public double AverageSkill
        {
            get { return averageSkill; }
            set { averageSkill = value; }
        }


        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            AverageSkill = Math.Round((double)(endurance + sprint + dribble + shooting + passing) / 5);
        }

        public Player()
        {
        }
    }
}
