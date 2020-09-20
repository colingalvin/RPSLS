using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Rock : Gestures // IS A GESTURE
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Rock()
        {
            name = "Rock";
            canBeatRock = false;
            canBeatPaper = false;
            canBeatScissors = true;
            canBeatLizard = true;
            canBeatSpock = false;
        }

        // member methods (CAN DO)
    }
}
