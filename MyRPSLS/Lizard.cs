using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Lizard : Gestures // IS A GESTURE
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Lizard()
        {
            name = "Lizard";
            canBeatRock = false;
            canBeatPaper = true;
            canBeatScissors = false;
            canBeatLizard = false;
            canBeatSpock = true;
        }

        // member methods (CAN DO)
    }
}
