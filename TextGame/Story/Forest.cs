using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    class Forest : GameStory
    {
        public override void MainStory()
        {
            Console.WriteLine("The forest is dark and gloomy. Shadows seem to loom everywhere.");
            Console.WriteLine("");
        }
        public override void SearchLocation()
        {
            throw new NotImplementedException();
        }
    }
}
