using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPSLS
{
    abstract class Player
    {
        // member variables (HAS A)
            // name
            // list of gestures

        // constructor (SPAWN)
        public Player(string name) // Human constructor
        {
            // choose name
            // instantiate list of gesture objects
            // add gestures to list
        }

        public Player() // AI constructor
        {
            // hard-coded name
            // instantiate list of gesture objects
            // add gestures to list
        }

        // member methods (CAN DO)
            // abstract ChooseGesture
    }
}
