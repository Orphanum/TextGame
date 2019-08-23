using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Graveyard : GameStory
    {
        public Graveyard()
            : base("Graveyard")
        {

        }
        public override void MainStory()
        {
            Console.WriteLine("You arrive at the graveyard. The atmosphere is near terrifying.");
            Console.WriteLine("The blackened sky combined with the spooky sounds makes this a place you do NOT want to stay in.");
        }
        public override void SearchLocation()
        {
            Console.WriteLine("\nDespite your gut feeling you decide to take a closer look around the area.");
            Console.WriteLine("Most of the graves here are old and decrepit. Clearly nobody is caring for them.");
            Console.WriteLine("The writing is hardly readable. At the centre of the graveyard, there's a crypt.");
            Console.WriteLine("It appears to be unlocked.");

        }
    }
}
