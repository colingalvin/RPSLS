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

        public void DisplayGestures() // Display available gestures
        {
            int i = 1;
            foreach(Gestures gesture in gestures)
            {
                Console.WriteLine($"  Type {i} for {gesture.name}");
                i++;
            }
            Console.WriteLine();
        }

        public Gestures ChooseGesture(string userInput)
        {
            Gestures gesture = null;
            switch(userInput)
            {
                case "1":
                    gesture = gestures[0];
                    break;
                case "2":
                    gesture = gestures[1];
                    break;
                case "3":
                    gesture = gestures[2];
                    break;
                case "4":
                    gesture = gestures[3];
                    break;
                case "5":
                    gesture = gestures[4];
                    break;
            }
            return gesture;
        }
            // display gestures
            // abstract ChooseGesture
    }
}
