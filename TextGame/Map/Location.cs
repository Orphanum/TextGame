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

        public Location(
            string _name,
            params Location[] borders)
        {
            foreach (Location border in borders)
            {
                Borders.Add(border);
            }
            Name = _name;
        }

        public static Location Crossroad;
        public static Location Castle;
        public static Location Village;
        public static Location Beach;
        public static Location Forest;
        public static Location Crypt;

        public static void CreateMap()
        {
            for (var i = 0; i < 3; i++)
            {
                Crossroad = new Location("Crossroad", Forest, Village, Beach, Crypt);
                Forest = new Location("Forest", Castle, Crossroad);
                Castle = new Location("Castle", Forest);
                Village = new Location("Village", Beach, Crossroad, Crypt);
                Crypt = new Location("Crypt", Crossroad, Village);
                Beach = new Location("Beach", Village, Crossroad);
            }
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

