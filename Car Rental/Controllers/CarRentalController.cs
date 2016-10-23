using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Rental.Controllers
{
    public class CarRentalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}