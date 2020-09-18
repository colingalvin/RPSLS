using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Human : Player // (IS A PLAYER)
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Human(string playerNumber)
            : base()  // Instantiate list of gestures and gesture objects
        {
            Console.Write($"Please enter the name for {playerNumber}: \n");
            name = Console.ReadLine();
        }

        // member methods (CAN DO)

        public override void DisplayGestures() // Display available gestures
        {
            int i = 1;
            foreach (Gestures gesture in gestures)
            {
                Console.WriteLine($"  Type {i} for {gesture.name}");
                i++;
            }
            Console.WriteLine();
        }

        public override Gestures ChooseGesture(string userInput)
        {
            Gestures gesture = null;
            switch (userInput)
            {
                case "1":
                    gesture = gestures[0];
                    break;
                case "2":
                    gesture = gestures[1];
                    break;
                case "3":
                    gesture = gestures[2];
                    break;
                case "4":
                    gesture = gestures[3];
                    break;
                case "5":
                    gesture = gestures[4];
                    break;
            }
            return gesture;
        }
    }
}
