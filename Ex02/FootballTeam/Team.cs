using System;
using System.Collections;
using System.Collections.Generic;

namespace FootballTeam
{
    class Team : IEnumerable<Player>
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public void Add(Player player)
        {
            Players.Add(player);
        }

        public void Remove(string player)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Name==player)
                {
                    Players.Remove(Players[i]);
                    return;
                }
            }
                throw new ArgumentException($"Player {player} is not in {Name} team.");
        }

        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var item in Players)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
