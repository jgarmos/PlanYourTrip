using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanYourTrip.Models
{
    public class Place
    {
        public int Id { get; set; }
        public String PlaceName { get; set; }
        public string GeoLong { get; set; }
        public string GeoLat { get; set; }

        public Place() { }
        public Place(int id, string placeName, string geoLong, string geoLat)
        {
            Id = id;
            PlaceName = placeName;
            GeoLong = geoLong;
            GeoLat = geoLat;
        }

    }
}