using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Paper : Gestures // IS A GESTURE
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Paper()
        {
            name = "Paper";
            canBeatRock = true;
            canBeatPaper = false;
            canBeatScissors = false;
            canBeatLizard = false;
            canBeatSpock = true;
        }

        // member methods (CAN DO)
    }
}
