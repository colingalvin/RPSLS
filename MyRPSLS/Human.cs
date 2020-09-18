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
        public Human()
            : base()  // Instantiate list of gestures and gesture objects
        {
            Console.Write("Please enter the name for Player One: \n");
            name = Console.ReadLine();
        }

        // member methods (CAN DO)

            // override ChooseGestures()
                // display list of gestures
                // user choose
                // clear console so 2nd player cannot see choice
                // return chosen gesture
    }
}
