using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    public class Player
    {
        public int Score { get; set; }
        public string Name { get; set; }

        public Player(string username)
        {
            Score = 0;
            Name = username;
        }
    }
}
