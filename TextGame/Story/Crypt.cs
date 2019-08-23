using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Artwork;

namespace TextGame.Story
{
    class Crypt : GameStory
    {
        public Crypt()
            : base("Crypt")
        {

        }
        public override void MainStory()
        {
            Console.WriteLine("The crypt is in the same decrepit state as the rest of the graveyard.");
            Console.WriteLine("The construction appears to be of a higher quality however.");
            Console.WriteLine("Inside there's a stone stair that leads further down.");
        }
        public override void SearchLocation()
        {
            Console.WriteLine("\nYou decide to head further in. At the end of the stairs there's a room.");
            Console.WriteLine("At the centre is a stone sarcophagus, the lid has been pushed off.");
            Console.WriteLine("Inside, there's a golden key, but nothing else, and certainly no corpse.");
            Key.ArtKey();
            Program.HasKey = true;
        }
    }
}
