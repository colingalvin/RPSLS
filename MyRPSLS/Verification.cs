using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Verification
    {
        // member variables

        // constructor

        // member methods
        
        public static string VerifySwitchCase(string userInput, int start, int end) // verify within range
        {
            string verifiedUserInput = "";
            bool isNumber = false;
            bool isWithinRange = false;
            while (isNumber == false || isWithinRange == false)
            {
                isNumber = IsNumber(userInput);
                if (isNumber == true)
                {
                    isWithinRange = IsWithinRange(userInput, start, end);
                    if (isWithinRange == true)
                    {
                        verifiedUserInput = userInput;
                    }
                    else
                    {
                        Console.Write("Invalid choice - please choose a valid menu option: ");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Invalid choice - please choose a valid menu option: ");
                    userInput = Console.ReadLine();
                }
            }
            return verifiedUserInput;
        }

        public static string VerifyOddNumber(string userInput)
        {
            string verifiedUserInput = "";
            bool isNumber = false;
            bool isPositive = false;
            bool isOdd = false;

            while (isNumber == false || isPositive == false || isOdd == false)
            {
                isNumber = IsNumber(userInput);
                if (isNumber == true)
                {
                    isPositive = IsPositive(userInput);
                    if (isPositive == true)
                    {
                        isOdd = IsOddNumber(userInput);
                        if (isOdd == true)
                        {
                            verifiedUserInput = userInput;
                        }
                        else
                        {
                            Console.Write("Invalid choice - please choose a positive, odd number: ");
                            userInput = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Write("Invalid choice - please choose a positive, odd number: ");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Invalid choice - please choose a positive, odd number: ");
                    userInput = Console.ReadLine();
                }
            }
            return verifiedUserInput;
        }

        private static bool IsNumber(string userInput) // verify integer
        {
            bool isNumber = int.TryParse(userInput, out _); // Discard output
            return isNumber;
        }

        private static bool IsPositive(string userInput) // verify number is positive
        {
            int userInputInt = int.Parse(userInput);
            bool isPositive = false;
            if(userInputInt > 0)
            {
                isPositive = true;
                return isPositive;
            }
            else
            {
                return isPositive;
            }
        }

        private static bool IsOddNumber(string userInput) // verify number is odd (must be positive)
        {
            int userInputInt = int.Parse(userInput);
            bool isOdd = false;
            if (userInputInt % 2 != 0)
            {
                isOdd = true;
                return isOdd;
            }
            else
            {
                return isOdd;
            }
        }

        private static bool IsWithinRange(string userInput, int start, int end) // verify within a range of acceptable numbers
        {
            int userInputInt = int.Parse(userInput);
            bool isWithinRange = false;
            if (userInputInt >= start && userInputInt <= end)
            {
                isWithinRange = true;
                return isWithinRange;
            }
            else
            {
                return isWithinRange;
            }
        }
    }
}
