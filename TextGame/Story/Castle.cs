using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Castle : GameStory
    {
        public Castle()
            : base("Castle")
        {

        }
        public override void MainStory()
        {
            Console.WriteLine("placeholder castle");
        }
        public override void SearchLocation()
        {
            throw new NotImplementedException();
        }
    }
}
