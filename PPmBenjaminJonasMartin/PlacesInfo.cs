using PPmBenjaminJonasMartin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmBenjaminJonasMartin
{
    internal class PlacesInfo
    {
        public List<PlacesToBe> SputnikPlaces { get; set; }

        public void PlacesInformation()
        {
            while (true)
            {
                Console.WriteLine("Press 1 to check Telemark");
                Console.WriteLine("Press 2 to check Vestold");


                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        
                        PrintCityInfoTelemark();
                        LoadOut();

                        break;
                    case "2": 
                        PrintCityInfoVestfold();
                        LoadOut();
                       
                        break;
                }
            }
        }

        static void LoadOut()
        {
            Console.WriteLine("Sputnik is travelling...");
            Thread.Sleep(400);
            Console.WriteLine("Sputnik is travelling...");
            Thread.Sleep(400);
            Console.WriteLine("Sputnik is travelling...");
            Thread.Sleep(400);
        }

        public void PrintCityInfoTelemark()
        {
            List<PlacesToBe> place = new List<PlacesToBe>();
            PlacesToBe place1 = new PlacesToBe("Skien", "Sputnik is trying to fish in the town square");
            place.Add(place1);
            LoadOut();
            PlacesToBe place2 = new PlacesToBe("Porsgrunn", "Sputnik is now running around in the local Kiwi");
            place.Add(place2);
            LoadOut();
            PlacesToBe place3 = new PlacesToBe("Ulefoss", "Sputnik is now in the local Polet. Good luck finding anything in there");
            place.Add(place3);

            foreach (PlacesToBe placesToBe in place)
            {
                Console.WriteLine($"Sputnik is now in {placesToBe.PlaceName}, doing {placesToBe.PlaceInfo}");
            }
        }
        public void PrintCityInfoVestfold()
        {
            List<PlacesToBe> place = new List<PlacesToBe>();
            PlacesToBe place1 = new PlacesToBe("Tønsberg", "Sputnik is visiting his grandmother");
            place.Add(place1);
            LoadOut();
            PlacesToBe place2 = new PlacesToBe("Larvik", "Sputnik is infiltrating GET Academy");
            place.Add(place2);

            foreach (PlacesToBe placesToBe in place)
            {
                Console.WriteLine($"Sputnik is now in {placesToBe.PlaceName}, doing {placesToBe.PlaceInfo}");
            }

        }
    }
}
