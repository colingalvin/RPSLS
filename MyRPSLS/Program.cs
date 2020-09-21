using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamePlay.DisplayWelcomeScreen(); // Welcome screen, display rules
            //string numberOfPlayers = GamePlay.ChoosePlayers(); // choose single (Human v AI) or multi-player (Human v Human)
            //string verifiedNumberOfPlayers =  Verification.VerifyChoiceWithinRange(numberOfPlayers, 1, 2);
            //string numberOfRounds = GamePlay.ChooseRounds(); // Choose # of rounds (best of)
            //string verifiedNumberOfRounds = Verification.VerifyPositveOddNumber(numberOfRounds);
            bool playAgain = false;
            do
            {
                GamePlay game = new GamePlay(); // Construct appropriate game (constructor triggered by choice above)
                game.PlayGame();
                playAgain = game.EndGame();
            }
            while (playAgain == true);

            // Add play another game option?
        }
    }
}
