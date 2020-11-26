using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player : IComparable<Player>
    {
        private int playerID { get; set; }
        public int PlayerID { get; }

        public string PlayerName { get; set; }

        public int Score { get; set; }

        public List<int> PlayerHighScores = new List<int>();

        public Player(int a, string b, int c)
        {
            PlayerID = a;
            PlayerName = b;
            Score = c;
        }

        public void IncreaseScore(int a)
        {
            Score += a;
            if (Score > Program.highestScore)
            {
                Program.highestScore = this.Score;
            }
            
        }

        public void ToString()
        {
            string stringID = this.PlayerID.ToString();
            string stringScore = this.Score.ToString();

            Console.WriteLine("{0,-10}{1,-15}{2,-10}", stringID ,this.PlayerName ,stringScore);  
        }

        public int CompareTo(Player obj)
        {
            return Score.CompareTo(obj.Score);
        }
    }
}
