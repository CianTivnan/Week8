using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        private int playerID { get; set; }
        public int PlayerID { get; }

        public string PlayerName { get; set; }

        public int Score { get; set; }

        public Player(int a, string b, int c)
        {
            PlayerID = a;
            PlayerName = b;
            Score = c;
        }

        public void IncreaseScore(int a)
        {
            Score += a;
        }

    }
}
