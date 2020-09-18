using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    class Spock : Gestures // IS A GESTURE
    {
        // member variables (HAS A)

        // constructor (SPAWN)
        public Spock()
        {
            name = "Spock";
            canBeatRock = true;
            canBeatPaper = false;
            canBeatScissors = true;
            canBeatLizard = false;
            canBeatSpock = false;
        }
        // member methods (CAN DO)
    }
}
