using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Crossroad : GameStory
    {
        public Crossroad()
            : base("Crossroad")
        {

        }
        public override void MainStory()
        {
            Console.WriteLine("There's several paths forking out around you.");
            Console.WriteLine("A quick look around you reveals a forest.");
            Console.WriteLine("A bit further in the distance you can see a village, with a nearby beach.");
            Console.WriteLine("The last path leads to a graveyard behind the village.");
        }
        public override void SearchLocation()
        {
            Console.WriteLine("Besides a few trees and some rocks, it's not very interesting here.");
            Console.WriteLine("It does look like someone has buried something in the center of the crossroad however.");
            if (Program.HasShovel == false) Console.WriteLine("If only you had a shovel.");
            if (Program.HasShovel == true)
            {
                Console.WriteLine("While the shovel is pretty crap, it does the job.");
                Console.WriteLine("You begin digging, and it doesn't take long till you can hear a metallic clunk");
                Console.WriteLine("The hole you just dug up contains a metal box.");
                Console.WriteLine("Inside, you find a faded photograph, some black dirt, a small bone and a wilted flower.");
            }
        }
    }
}
