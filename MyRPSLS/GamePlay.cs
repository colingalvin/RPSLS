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
        double numberOfRounds;

        // constructor
        public GamePlay()
        {
            DisplayWelcomeScreen();
            string numberOfPlayers = ChoosePlayers(); // choose single (Human v AI) or multi-player (Human v Human)
            string verifiedNumberOfPlayers = Verification.VerifySwitchCase(numberOfPlayers, 1, 2);
            string numberOfRounds = ChooseRounds(); // Choose # of rounds (best of)
            string verifiedNumberOfRounds = Verification.VerifyOddNumber(numberOfRounds);
            switch (verifiedNumberOfPlayers)
            {
                case "1": // Single player
                    playerOne = new Human("Player One");
                    playerTwo = new AI();
                    break;
                case "2": // Multi-player
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    break;
            }
            this.numberOfRounds = double.Parse(verifiedNumberOfRounds);
        }

        // member methods

        public void DisplayWelcomeScreen()
        {
            Console.WriteLine("Wecome to Rock/Paper/Scissors/Lizard/Spock!\n"); // Welcome message
            Console.WriteLine("The rules for the game are simple:"); // Display rules
            Console.WriteLine("  Rock crushes Scissors\n  Scissors cuts Paper\n  Paper covers Rock\n  Rock crushes Lizard\n  Lizard poisons Spock\n  Spock smashes Scissors\n  Scissors decapitates Lizard\n  Lizard eats Paper\n  Paper disproves Spock\n  Spock vaporizes Rock");
            Console.WriteLine("\n...simple, right? Don't worry, we'll help you out during the game!\n");
        }

        public string ChoosePlayers()
        {
            Console.Write("Type 1 for single-player (Human v Computer) or 2 for multi-player (Human v Human): "); // Choose single or multi-player, # of rounds
            string userInput = Console.ReadLine();
            string verifiedUserInput = Verification.VerifySwitchCase(userInput, 1, 2);
            Console.WriteLine(); // Spacing
            return verifiedUserInput;
        }

        public string ChooseRounds()
        {
            Console.Write("Enter number of rounds (best of): ");
            string userInput = Console.ReadLine();
            string verifiedUserInput = Verification.VerifyOddNumber(userInput);
            Console.WriteLine(); // Spacing
            return verifiedUserInput;
        }

        public void PlayGame()
        {
            // while either player score < (# rounds/2)
            while(playerOne.score < (numberOfRounds/2) && playerTwo.score < (numberOfRounds / 2))
            {
                DisplayScoreboard(); // Display scoreboard
                playerOne.DisplayGestures(); 
                Console.Write($"{playerOne.name}, make your choice! "); // Player one chooses gesture from list
                string playerOneChoice = Console.ReadLine(); // Capture choice as string
                string verifiedPlayerOneChoice = Verification.VerifySwitchCase(playerOneChoice, 1, 5);
                Gestures playerOneGesture = playerOne.ChooseGesture(verifiedPlayerOneChoice); // Pass string in to return Gesture object
            
                DisplayScoreboard(); // Clears console so that player two cannot see player 1 choice
                playerTwo.DisplayGestures();
                if (playerTwo.name == "HAL9000") // If player two is AI
                {
                    Gestures playerTwoGestureAI = playerTwo.ChooseGesture("");
                    CompareGestures(playerOneGesture, playerTwoGestureAI);
                }
                else // If player two is Human
                {
                    Console.Write($"{playerTwo.name}, make your choice! "); // Player one chooses gesture from list
                    string playerTwoChoice = Console.ReadLine(); // Capture choice as string
                    string verifiedPlayerTwoChoice = Verification.VerifySwitchCase(playerTwoChoice, 1, 5);
                    Gestures playerTwoGesture = playerTwo.ChooseGesture(verifiedPlayerTwoChoice); // Pass string in to return Gesture object

                    CompareGestures(playerOneGesture, playerTwoGesture); // Compare Gestures, display round winner
                }
            }
        }

        public void DisplayScoreboard()
        {
            Console.Clear();
                // display current score of all players
                // display "Best of: " to keep track of rounds needed to play
            Console.WriteLine($"{playerOne.name}: {playerOne.score}    {playerTwo.name}: {playerTwo.score}    Best of: {numberOfRounds} \n");
        }

        public void CompareGestures(Gestures playerOneGesture, Gestures playerTwoGesture)
        {
            Console.WriteLine($"{playerOne.name} chose {playerOneGesture.name}, {playerTwo.name} chose {playerTwoGesture.name}\n");

            if (playerOneGesture.name == playerTwoGesture.name) // If gestures equal, declare a tie
            {
                Console.WriteLine("Tie round!");
                Console.Write("Press enter to continue.");
                Console.ReadLine();
                return;
            }
            else // If gestures unequal
            {
                switch (playerOneGesture.name)
                {
                    case "Rock":
                        if(playerTwoGesture.canBeatRock)
                        {
                            DisplayRoundWinner(playerTwoGesture, playerOneGesture, playerTwo);
                        }
                        else
                        {
                            DisplayRoundWinner(playerOneGesture, playerTwoGesture, playerOne);
                        }
                        break;
                    case "Paper":
                        if (playerTwoGesture.canBeatPaper)
                        {
                            DisplayRoundWinner(playerTwoGesture, playerOneGesture, playerTwo);
                        }
                        else
                        {
                            DisplayRoundWinner(playerOneGesture, playerTwoGesture, playerOne);
                        }
                        break;
                    case "Scissors":
                        if (playerTwoGesture.canBeatScissors)
                        {
                            DisplayRoundWinner(playerTwoGesture, playerOneGesture, playerTwo);
                        }
                        else
                        {
                            DisplayRoundWinner(playerOneGesture, playerTwoGesture, playerOne);
                        }
                        break;
                    case "Lizard":
                        if (playerTwoGesture.canBeatLizard)
                        {
                            DisplayRoundWinner(playerTwoGesture, playerOneGesture, playerTwo);
                        }
                        else
                        {
                            DisplayRoundWinner(playerOneGesture, playerTwoGesture, playerOne);
                        }
                        break;
                    case "Spock":
                        if (playerTwoGesture.canBeatSpock)
                        {
                            DisplayRoundWinner(playerTwoGesture, playerOneGesture, playerTwo);
                        }
                        else
                        {
                            DisplayRoundWinner(playerOneGesture, playerTwoGesture, playerOne);
                        }
                        break;
                }
                Console.Write("Press enter to continue.");
                Console.ReadLine();
                return;
            }
        }

        public void DisplayRoundWinner(Gestures winningGesture, Gestures losingGesture, Player winner)
        {
            string verb = "";
            switch(winningGesture.name)
            {
                case "Rock":
                    switch(losingGesture.name)
                    {
                        default:
                            verb = "crushes";
                            break;
                    }
                    break;
                case "Paper":
                    switch(losingGesture.name)
                    {
                        case "Rock":
                            verb = "covers";
                            break;
                        case "Spock":
                            verb = "disproves";
                            break;
                    }
                    break;
                case "Scissors":
                    switch(losingGesture.name)
                    {
                        case "Paper":
                            verb = "cuts";
                            break;
                        case "Lizard":
                            verb = "decapitates";
                            break;
                    }
                    break;
                case "Lizard":
                    switch(losingGesture.name)
                    {
                        case "Spock":
                            verb = "poisons";
                            break;
                        case "Paper":
                            verb = "eats";
                            break;
                    }
                    break;
                case "Spock":
                    switch(losingGesture.name)
                    {
                        case "Scissors":
                            verb = "smashes";
                            break;
                        case "Rock":
                            verb = "vaporizes";
                            break;
                    }
                    break;
            }
            // add veribage for what winning gesture does to losing gesture
            Console.WriteLine($"{winningGesture.name} {verb} {losingGesture.name}, {winner.name} wins this round!");
            winner.score++;
        }

        public bool EndGame()
        {
            Console.Clear();
            Console.WriteLine("The game is over! Final points:\n");
            Console.WriteLine($"{playerOne.name}: {playerOne.score}; {playerTwo.name}: {playerTwo.score}.\n");
            if(playerOne.score > playerTwo.score)
            {
                Console.WriteLine($"{playerOne.name} wins!");
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} wins!");
            }
            bool playAgain = Replay();
            Console.Clear();
            return playAgain;
        }

        public bool Replay()
        {
            bool playAgain = false;
            Console.Write("\n\tType 1 to play again, 2 to quit. ");
            string userInput = Console.ReadLine();
            string verifiedUserInput = Verification.VerifySwitchCase(userInput, 1, 2);
            if (verifiedUserInput == "1")
            {
                playAgain = true;
            }
            return playAgain;
        }
    }
}
