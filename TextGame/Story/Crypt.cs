using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("placeholder crypt");
        }
        public override void SearchLocation()
        {
            Program.HasKey = true;
        }
    }
}
