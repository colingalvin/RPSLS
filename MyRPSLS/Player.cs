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
        public int score;

        // constructor (SPAWN)
        public Player()
        {
            score = 0;
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

        // make abstract so that AI does not display choices
        public void DisplayGestures() // Display available gestures
        {
            int i = 1;
            foreach (Gestures gesture in gestures)
            {
                Console.WriteLine($"  Type {i} for {gesture.name}");
                i++;
            }
            Console.WriteLine();
        }

        public abstract Gestures ChooseGesture(string userInput);
            // display gestures
            // abstract ChooseGesture
    }
}
