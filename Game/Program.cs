using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static int highestScore = 0;

        static void Main(string[] args)
        {
            List<Player> Players = new List<Player>();
            Player player1 = new Player(1, "Millie", 0);
            Players.Add(player1);
            Player player2 = new Player(2, "Katie", 0);
            Players.Add(player2);
            Player player3 = new Player(3, "Kevin", 0);
            Players.Add(player3);
            Player player4 = new Player(4, "Conor", 0);
            Players.Add(player4);
            Player player5 = new Player(5, "Pauline", 0);
            Players.Add(player5);

            DisplayScores(Players);

            Input(Players);



            Console.WriteLine("hello");

            Console.WriteLine(highestScore);

            List<Player> DisplayPlayers = new List<Player>();
            DisplayPlayers.Add(player1);
            DisplayPlayers.Add(player4);

            DisplayPlayerDetails(DisplayPlayers);

        }

        private static void Input(List<Player> Players)
        {
            int input = 999;
            Console.Write("Please enter number of player for score update : ");
            input = int.Parse(Console.ReadLine().Trim());
            while (input != 0)
            {
                switch (input)
                {
                    case 1:
                        Players[0].IncreaseScore(1);
                        break;
                    case 2:
                        Players[1].IncreaseScore(1);
                        break;
                    case 3:
                        Players[2].IncreaseScore(1);
                        break;
                    case 4:
                        Players[3].IncreaseScore(1);
                        break;
                    case 5:
                        Players[4].IncreaseScore(1);
                        break;
                }
                DisplayScores(Players);
                Console.Write("Please enter number of player for score update : ");
                input = int.Parse(Console.ReadLine().Trim());
            }
        }

        static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-15}{2,-10}" ,"UserID" ,"Username" ,"Score");
            foreach (Player player in players)
            {
                player.ToString();
            }
        }

        static void DisplayScores(List<Player> players)
        {
            Console.WriteLine("\n{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}" ,"Player 1" ,"Player 2" ,"Player 3" ,"Player 4" ,"Player 5");
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", players[0].Score, players[1].Score, players[2].Score, players[3].Score, players[4].Score);
        }
    }
}
