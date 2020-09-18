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

        // constructor
        public GamePlay() // Single player
        {
            // create new human
            // create new AI
            // # of rounds
        }

        // member methods

            // DisplayWelcomeScreen
                // Welcome message
                // Display rules
                // Choose single or multi-player, # of rounds
                    // trigger appropriate constructor

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
