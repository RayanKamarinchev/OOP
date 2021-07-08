using System;
using System.Collections.Generic;

namespace FootballTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(";");
            List<Team> teams = new List<Team>();
            while (command[0]!="END")
            {
                try
                {
                    switch (command[0])
                    {
                        case "Team":
                            teams.Add(new Team(command[1]));
                            break;
                        case "Add":
                            if (ContainTeam(teams, command[1]))
                            {
                                Team theTeam = teams[IndexOfTeam(teams, command[1])];
                                theTeam
                                    .Players
                                    .Add(new Player(command[2]
                                    , int.Parse(command[3])
                                    , int.Parse(command[4])
                                    , int.Parse(command[5])
                                    , int.Parse(command[6])
                                    , int.Parse(command[7])));
                            }
                            else
                            {
                                Console.WriteLine($"Team {command[1]} does not exist.");
                            }
                            break;
                        case "Remove":
                            if (ContainTeam(teams, command[1]))
                            {
                                Team theTeam = teams[IndexOfTeam(teams, command[1])];
                                if (ContainPlayer(theTeam, command[2]))
                                {
                                    theTeam.Remove(command[2]);
                                }
                                else
                                {
                                    Console.WriteLine($"Player {command[2]} is not in {command[1]} team.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Team {command[1]} does not exist.");
                            }
                            break;
                        case "Rating":
                            if (ContainTeam(teams, command[1]))
                            {
                                Team theTeam = teams[IndexOfTeam(teams, command[1])];
                                double rating = 0;
                                foreach (var item in theTeam.Players)
                                {
                                    rating += item.AverageSkill;
                                }
                                if (Double.IsNaN(rating / theTeam.Players.Count))
                                {
                                    Console.WriteLine($"{theTeam.Name} - 0");
                                }
                                else
                                {
                                    Console.WriteLine($"{theTeam.Name} - {rating / theTeam.Players.Count}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Team {command[1]} does not exist.");
                            }
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                command = Console.ReadLine().Split(";");
            }
            
        }

        static int IndexOfTeam(List<Team> teams, string name)
        {
            int result = -1;
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Name == name)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        static bool ContainTeam(List<Team> teams, string name)
        {
            foreach (var item in teams)
            {
                if (item.Name==name)
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainPlayer(Team team, string player)
        {
            foreach (var item in team)
            {
                if (item.Name==player)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
