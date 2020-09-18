using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay.DisplayWelcomeScreen(); // Welcome screen, display rules
            string numberOfPlayers = GamePlay.ChoosePlayers(); // choose single (Human v AI) or multi-player (Human v Human)
            string numberOfRounds = GamePlay.ChooseRounds(); // Choose # of rounds (best of)
            GamePlay game = new GamePlay(numberOfPlayers, numberOfRounds); // Construct appropriate game (constructor triggered by choice above)
            // Begin!
        }
    }
}
