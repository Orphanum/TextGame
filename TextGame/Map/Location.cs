using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Map
{
    class Location
    {
        public string Name;
        public List<Location> Borders = new List<Location>();

        public Location(string _name)
        {
            Name = _name;
        }

        public void AddBorders(params Location[] borders)
        {
            foreach (Location border in borders)
            {
                Borders.Add(border);
            }
        }

        public static Location Crossroad;
        public static Location Castle;
        public static Location Village;
        public static Location Beach;
        public static Location Forest;
        public static Location Crypt;
        public static Location Graveyard;

        public static void CreateMap()
        {
            Crossroad = new Location("Crossroad");
            Forest = new Location("Forest");
            Castle = new Location("Castle");
            Village = new Location("Village");
            Crypt = new Location("Crypt");
            Beach = new Location("Beach");
            Graveyard = new Location("Graveyard");
               

            Crossroad.AddBorders(Forest, Village, Beach, Graveyard);
            Forest.AddBorders(Castle, Crossroad);
            Castle.AddBorders(Forest);
            Village.AddBorders(Beach, Crossroad, Graveyard);
            Crypt.AddBorders(Graveyard);
            Beach.AddBorders(Village, Crossroad);
            Graveyard.AddBorders(Crypt, Village, Crossroad);

        }
        public void ShowBorders()
        {
            foreach (Location border in Borders)
            {
                if (border != null)
                {
                    Console.WriteLine(border.Name);
                }
            }
        }



    }
}

