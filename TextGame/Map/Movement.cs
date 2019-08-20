using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame;
using TextGame.Story;

namespace TextGame.Map
{
    class Movement
    {
        public static void Move()
        {
            Console.WriteLine("\nYou're currently at: " + Program.CurrentLocation.Name);
            Console.WriteLine("You may move to:");
            Program.CurrentLocation.ShowBorders();
            Console.WriteLine("\nWhere would you like to move?");
            var UserInput = Console.ReadLine();

            Location location = Program.CurrentLocation.Borders.FirstOrDefault(l => l.Name == UserInput);

            if (UserInput == location.Name)
            {
                if (UserInput == Location.Beach.Name)
                {
                    //Beach.BeachStory();
                }
                if (UserInput == Location.Crypt.Name)
                {
                    Program.Key = true;
                }
            }
            else Console.WriteLine("That is not a valid location.");


            //}

            //var name = "fkjghjb";
            //var location = CurrentLocation.Borders.FirstOrDefault(l=>l.Name==name)


            //    Location location2 = null;
            //foreach(var l in CurrentLocation.Borders)
            //{
            //    if(l.Name == name)
            //    {
            //        location2 = l;
            //        break;
            //    }
            //}




        }
        public static string Input()
        {
            Console.WriteLine();
            Console.Write("Kommando: ");
            return Console.ReadLine().ToUpper();
        }

    }

}
