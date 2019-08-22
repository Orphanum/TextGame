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

        }
    }
}
