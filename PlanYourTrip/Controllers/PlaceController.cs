using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanYourTrip.Models;

namespace PlanYourTrip.Controllers
{
    public class PlaceController : Controller
    {
        // GET: Place
        public ActionResult Index()
        {
            Place myplace1 = new Place(1, "Mi Casa Actual", "55.968701", "-3.185612");
            Place myplace2 = new Place(2, "Mi primera Casa", "55.972841", "-3.175769");
            Place myplace3 = new Place(3, "Mi segunda Casa", "55.970580", " - 3.173939");
            List <Place> listPlaces = new List<Place> { myplace1, myplace2, myplace3 };

            PlacesToVisit placeToVisit = new PlacesToVisit(listPlaces);

            return View(myplace1);
        }
    }
}