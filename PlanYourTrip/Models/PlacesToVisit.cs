using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanYourTrip.Models
{
    public class PlacesToVisit
    {
        public Place place { get; set; }
        public List<Place> Places { get; set; }

        public PlacesToVisit (List<Place> places)
        {
            Places = places;
        }

    }
}