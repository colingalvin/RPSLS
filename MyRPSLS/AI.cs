using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class AI : Player // IS A PLAYER
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public AI()
            : base() // Instantiate list of gestures and gesture objects
        {
            name = "HAL9000";
        }

        // member methods (CAN DO)

        public override Gestures ChooseGesture(string userInput) // AI generates random choice 
        {
            Random random = new Random();
            int randomChoice = random.Next(0, (gestures.Count-1)); // dynamic for number of gestures to choose from
            return gestures[randomChoice]; // returns randomly-chosen gesture
        }
    }
}
