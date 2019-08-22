using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Story
{
    public abstract class GameStory
    {
        public string Name;
        public GameStory(string _name)
        {
            Name = _name;
        }
        public abstract void MainStory();
        public abstract void SearchLocation();
        public static void CreateStory()
        {
            var Forest = new Forest();
            var Beach = new Beach();
            var Village = new Village();
            var Castle = new Castle();
            var Crypt = new Crypt();
            var Crossroad = new Crossroad();
            var Graveyard = new Graveyard();

            Program.list.Add(Forest);
            Program.list.Add(Beach);
            Program.list.Add(Village);
            Program.list.Add(Castle);
            Program.list.Add(Crypt);
            Program.list.Add(Crossroad);
            Program.list.Add(Graveyard);
        }
    }

    
}
