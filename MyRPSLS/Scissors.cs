using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Scissors : Gestures // IS A GESTURE
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Scissors()
        {
            name = "Scissors";
            canBeatRock = false;
            canBeatPaper = true;
            canBeatScissors = false;
            canBeatLizard = true;
            canBeatSpock = false;
        }

        // member methods (CAN DO)
    }
}
