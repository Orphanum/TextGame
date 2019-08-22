using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Map;
using TextGame.Story;

namespace TextGame
{
    class Commands
    {
        public static void Help()
        {
            Program.ConsoleClear();
            Console.WriteLine("The available commands are:");
            Console.WriteLine("Help: Brings up this screen.");
            Console.WriteLine("Search: Search for stuff at the current location");
            Console.WriteLine("Move <location>: Moves to the location specified.");
            Console.WriteLine("Location: Shows your current location and related information.");
        }

        public static void LocationInformation()
        {
            Program.ConsoleClear();
            Console.WriteLine("Current location: " + Program.CurrentLocation.Name);
            Console.WriteLine("You may move to:");
            Program.CurrentLocation.ShowBorders();
        }
        public static void Search()
        {
            throw new NotImplementedException();
        }
        public static void Move()
        {
            Program.ConsoleClear();
            Console.WriteLine("\nYou're currently at: " + Program.CurrentLocation.Name);
            Console.WriteLine("You may move to:");
            Program.CurrentLocation.ShowBorders();
            Console.WriteLine("\nWhere would you like to move?");

            var UserInput = Console.ReadLine();

            Location location = Program.CurrentLocation.Borders.FirstOrDefault(l => l.Name == UserInput);

            if (location != null && UserInput == location.Name)
            {
                Program.CurrentLocation = location;
                
            }
            else if (location == null) Console.WriteLine("That is not a valid location.");
        }
    }
}
