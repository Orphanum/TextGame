using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Artwork;
using TextGame.Story;
using TextGame.Map;

namespace TextGame
{

    class Program
    {
        public static bool Key = false;
        public static Location CurrentLocation;
        static void Main(string[] args)
        {
            //Initializing
            GameIntroduction.ArtIntro();
            Location.CreateBorders();
            CurrentLocation = Location.Crossroad;
            //Initialization done

            Console.WriteLine("\n \n \n");
            Console.WriteLine("Would you like to play?");
            Console.WriteLine("'Yes' or 'No'?");
            Console.WriteLine("\n");

            

            var UserInput = Console.ReadLine().ToUpper();

            
            if (UserInput == "YES")
            {
                ConsoleClear();
                Introduction.Intro();
                Movement.Move();
                
                
            }
            while (true)
            {
                Movement.Move();
            }

        }
        public static void ConsoleClear()
        {
            Console.Clear();
        }
    }
}
