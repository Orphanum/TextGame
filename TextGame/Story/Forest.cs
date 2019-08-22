using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Artwork;

namespace TextGame.Story
{
    class Forest : GameStory
    {
        public Forest()
            : base("Forest")
        {

        }
        public override void MainStory()
        {
            Console.WriteLine("The forest is dark and gloomy. Shadows seem to loom everywhere.");
            Console.WriteLine("A path leads further in, but it ends in a dead end.");
            Console.WriteLine("The entire forest is weird. Even if it is night, you'd expect to hear some noise,");
            Console.WriteLine("but you can hear nothing. No bugs, no birds, nothing.");
        }
        public override void SearchLocation()
        {
            Gate.ArtGate();
            Console.WriteLine("You decide to go off the beaten path.");
            Console.WriteLine("After walking around for what seems to be forever, you come across a stone wall.");
            Console.WriteLine("Following it, you find a tall metal gate.");
            Console.WriteLine("The gate is locked however, and you see no way around it.");
            if (Program.HasKey == true)
            {
                Console.WriteLine("With the key you found in the crypt, you open the gate.");
                Console.WriteLine("ADD MORE");
            }
        }
    }
}
