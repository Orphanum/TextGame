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
            Console.WriteLine("placeholder graveyard");
        }
        public override void SearchLocation()
        {
            throw new NotImplementedException();
        }
    }
}
