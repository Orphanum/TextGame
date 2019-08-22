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
            Console.WriteLine("");
        }
        public override void SearchLocation()
        {
            throw new NotImplementedException();
        }
    }
}
