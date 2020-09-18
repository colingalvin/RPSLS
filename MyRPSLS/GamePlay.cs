using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class GamePlay
    {
        // member variables
        Player playerOne;
        Player playerTwo;
        int numberOfRounds;

        // constructor
        public GamePlay(string numberOfPlayers, string numberOfRounds)
        {
            switch(numberOfPlayers)
            {
                case "1": // Single player
                    playerOne = new Human();
                    playerTwo = new AI();
                    break;
                case "2": // Multi-player
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
            }
            this.numberOfRounds = int.Parse(numberOfRounds);
        }

        // member methods

        public static void DisplayWelcomeScreen()
        {
            Console.WriteLine("Wecome to Rock/Paper/Scissors/Lizard/Spock!\n"); // Welcome message
            Console.WriteLine("The rules for the game are simple:"); // Display rules
            Console.WriteLine("  Rock crushes Scissors\n  Scissors cuts Paper\n  Paper covers Rock\n  Rock crushes Lizard\n  Lizard poisons Spock\n  Spock smashes Scissors\n  Scissors decapitates Lizard\n  Lizard eats Paper\n  Paper disproved Spock\n  Spock vaporizes Rock");
            Console.WriteLine("\n...simple, right? Don't worry, we'll help you out during the game!\n");
        }

        public static string ChoosePlayers()
        {
            Console.Write("Type 1 for single-player (Human v Computer) or 2 for multi-player (Human v Human): "); // Choose single or multi-player, # of rounds
            string userInput = Console.ReadLine();
            Console.WriteLine(); // Spacing
            return userInput;
        }

        public static string ChooseRounds()
        {
            Console.Write("Enter number of rounds (best of): ");
            string userInput = Console.ReadLine();
            Console.WriteLine(); // Spacing
            return userInput;
        }


            // PlayGame
                // while either player score < (# rounds/2)
                    // Display scoreboard
                    // Trigger players to choose gesture
                    // Compare gestures, capture int result
                    // Display round winner

            // DisplayScoreboard
                // display current score of all players
                // display "Best of: " to keep track of rounds needed to play

            // CompareGestures(player1Gesture, player2Gesture)
                // int result = compare play1gesture.canBeat___.CompareTo(player2gesture.canBeat____
                    // result of 1 = player 1 wins
                    // result of -1 = player 2 wins
                    // result of 0 = players tie

            // DisplayRoundWinner(player1Gesture, player2Gesture, int roundResult)
                // int captured from comparing bool values of each gesture
                // display winning gesture
                // display player who choose winning gesture
                // increase player score
    }
}
