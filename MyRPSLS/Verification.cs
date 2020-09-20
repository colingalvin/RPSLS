using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        public static string VerifyPositveOddNumber(string userInput)
        {
            int userInputInteger; // stores successfully parsed input
            string validatedInput; // stores successfully verified input

            bool isInteger = int.TryParse(userInput, out userInputInteger);
            bool isOddAndPositive = false;
            if(userInputInteger % 2 != 0 && userInputInteger > 0) // number must be both odd and positive
            {
                isOddAndPositive = true;
            }
            // Input must be integer between start and end values of switch case before exiting while loop
            while (isInteger != true || isOddAndPositive != true)
            {
                Console.Write("Invalid choice - number must be both odd and positive. Please try again: ");
                userInput = Console.ReadLine();
                isInteger = int.TryParse(userInput, out userInputInteger);
                if (userInputInteger % 2 != 0 && userInputInteger > 0)
                {
                    isOddAndPositive = true;
                }
            }
            validatedInput = Convert.ToString(userInputInteger);
            return validatedInput;
        }

        // verify positive
        // verify odd
        // verify betwen range
        // verify integer
    }
}
