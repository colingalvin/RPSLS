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

            // override ChooseGestures()
                // randomly choose from list of gestures (#0-4)
                // return chosen gesture
    }
}
