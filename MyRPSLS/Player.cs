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

        public string name;
        public List<Gestures> gestures;

        // constructor (SPAWN)
        public Player()
        {
            gestures = new List<Gestures>();
            Rock Rock = new Rock();
            Paper Paper = new Paper();
            Scissors Scissors = new Scissors();
            Lizard Lizard = new Lizard();
            Spock Spock = new Spock();
            gestures.Add(Rock); // add gestures to list
            gestures.Add(Paper);
            gestures.Add(Scissors);
            gestures.Add(Lizard);
            gestures.Add(Spock);
        }

        // member methods (CAN DO)
            // abstract ChooseGesture
    }
}
