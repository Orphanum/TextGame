using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Village : GameStory
    {
        public Village()
            : base("Village")
        {

        }
        public override void MainStory()
        {
            Console.WriteLine("Placeholder village");
        }
        public override void SearchLocation()
        {
            Program.HasShovel = true;
            Console.WriteLine("You take a closer look around, and there is indeed no people here.");
            Console.WriteLine("You find rotten remains of food, and personal belongings, but no signs of life.");
            Console.WriteLine("As you're about to exit the village, you notice a shovel.");
            Console.WriteLine("Might as well bring it.");

        }
    }
}
