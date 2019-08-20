using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Commands
    {
        public static void Instructions()
        {
            Program.ConsoleClear();
            Console.WriteLine("The available commands are:");
            Console.WriteLine("Help: Brings up this screen.");
            Console.WriteLine("Search: Search for stuff at the current location");
            Console.WriteLine("Move <location>: Moves to the location specified.");
            Console.WriteLine("Current: Shows your current location and related information.");
        }

        public static void LocationInformation()
        {
            Console.WriteLine("Current location: " + Program.CurrentLocation);
            Console.WriteLine("You may move to:");
            Program.CurrentLocation.ShowBorders();
        }
        public static void Search()
        {

        }

    }
}
