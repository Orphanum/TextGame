using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Beach : GameStory
    {
        public Beach()
            : base("Beach")
        {
        }
        public override void MainStory()
        {
            Console.WriteLine("You arrive at the beach. It's eerily quiet, and you can hear the waves going back and forth");
            Console.WriteLine("It's beautiful here, but the completely blackened sky makes the entire area feel more spooky, than serene");
        }
        public override void SearchLocation()
        {
            Console.WriteLine("You take a look around, but there's not a whole lot here.");
            Console.WriteLine("The sand looks like sand and feels like sand. There's some rocks here and there.");
            Console.WriteLine("There appears to be no wildlife here however, not even any bugs.");
        }
    }
}
