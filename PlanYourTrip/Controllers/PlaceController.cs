﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlanYourTrip.Controllers
{
    public class PlaceController : Controller
    {
        // GET: Place
        public ActionResult Index()
        {
            return View();
        }
    }
}