using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    public abstract class GameStory
    {
        public abstract void MainStory();

        public static void CreateStory()
        {
            var Forest = new Forest();
            var Beach = new Beach();
            var Village = new Village();
            var Castle = new Castle();
            var Crypt = new Crypt();
            var Crossroad = new Crossroad();
        }
    }

    
}
