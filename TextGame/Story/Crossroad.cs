using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Crossroad : GameStory
    {
        public override void MainStory()
        {
            Console.WriteLine("There's several paths forking out around you.");
            Console.WriteLine("A quick look around you reveals a forest. A bit further in the distance you can see a village, with a nearby beach.");
            Console.WriteLine("The last path leads to a graveyard behind the village.");
        }
    }
}
