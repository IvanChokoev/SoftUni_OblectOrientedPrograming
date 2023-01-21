using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name { 
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty");
                }
                this.name = value;
            }
        }
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name);
            if (player is null)
            {
                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
            }
            this.players.Remove(player);
        }

        public int Rating
        {
            get { return CalculateTeamRating(); }
        }

        private int CalculateTeamRating()
        {
            if (this.players.Any())
            {
                return (int)Math.Round(this.players.Average(p => p.Stats));
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{this.name} - {this.Rating}";
        }
    }
}
