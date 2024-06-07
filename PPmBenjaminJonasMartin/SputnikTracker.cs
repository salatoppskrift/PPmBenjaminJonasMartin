using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmBenjaminJonasMartin
{
    internal class SputnikTracker
    {
        public PlacesInfo Places { get; set; }

        public SputnikTracker()
        {
            Places = new PlacesInfo();
            mainMenu();
        }

        public void mainMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Greatest Sputnik Tracker  that there is!!!");
                Console.WriteLine(
                "·················································································" +
                "\n:    _______  _______          _________ _________ _______  _______  _          :" +
                "\n:   (  ____ |(  ____ )| |   | ||__   __| |__   __|(  ____ |(  ____ )( (    /|   :" +
                "\n:   | (    | | (    )|| )   ( |   ) (       ) (   | (    |/| (    )||  |  ( |   :" +
                "\n:   | (_____ | (____)|| |   | |   | |       | |   | (__    | (____)||   | | |   :" +
                "\n:   (_____  )|  _____)| |   | |   | |       | |   |  __)   |     __)| (| |) |   :" +
                "\n:         ) || (      | |   | |   | |       | |   | (      | (| (   | | |   |   :" +
                "\n:   /|____) || )      | (___) |   | |       | |   | (____/|| ) | |__| )  |  |   :" +
                "\n:   |_______)|/       (_______)   )_(       )_(   (_______/|/   |__/|/    )_)   :" +
                "\n·················································································");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("press 1 to journey with sputtern");

                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        GoToTracker();
                            break;
                }
            }
        }
        public void GoToTracker()
        {
            var places = new PlacesInfo();
            places.PlacesInformation();
        }
    }
}
