using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmBenjaminJonasMartin
{
    public class PlacesToBe
    {
        
        public string PlaceName { get; set; }
        public string PlaceInfo { get; set; }


        public PlacesToBe(string placeName, string placeInfo)
        {
            PlaceName = placeName;
            PlaceInfo = placeInfo;
        }
    }
}
