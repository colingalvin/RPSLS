using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Verification
    {
        // member variables
        // verifiedUserInput

        // constructor

        // member methods
        public static string VerifyChoiceWithinRange(string userInput, int start, int end) // Verify user input is within appropriate bounds
        {
            int userInputInteger; // stores successfully parsed input
            string validatedInput; // stores successfully verified input

            bool isInteger = int.TryParse(userInput, out userInputInteger);
            // Input must be integer between start and end values of switch case before exiting while loop
            while (isInteger != true || userInputInteger < start || userInputInteger > end)
            {
                Console.Write("Invalid choice. Please try again: ");
                userInput = Console.ReadLine();
                isInteger = int.TryParse(userInput, out userInputInteger);
            }
            validatedInput = Convert.ToString(userInputInteger);
            return validatedInput;
        }

        public static string VerifyOddNumber(string userInput) // Verify user input is an odd number
        {
            int userInputInteger; // stores successfully parsed input
            string validatedInput; // stores successfully verified input

            bool isInteger = int.TryParse(userInput, out userInputInteger);
            bool isOdd = false;
            if(userInputInteger % 2 != 0)
            {
                isOdd = true;
            }
            // Input must be integer between start and end values of switch case before exiting while loop
            while (isInteger != true || isOdd != true)
            {
                Console.Write("Invalid choice - number must be odd. Please try again: ");
                userInput = Console.ReadLine();
                isInteger = int.TryParse(userInput, out userInputInteger);
                if (userInputInteger % 2 != 0)
                {
                    isOdd = true;
                }
            }
            validatedInput = Convert.ToString(userInputInteger);
            return validatedInput;
        }
    }
}
