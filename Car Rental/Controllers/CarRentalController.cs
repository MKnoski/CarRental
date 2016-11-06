using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental.Data.Services.Interfaces;
using Car_Rental.ViewModels;
using CarRental.Data.Context;
using CarRental.Data.Services;
using Car_Rental.Services.Interfaces;

namespace Car_Rental.Controllers
{
    public class CarRentalController : Controller
    {
        private readonly ICarRentalsQuery carRentalsQuery;

        public CarRentalController(ICarRentalsQuery carRentalsQuery)
        {
            this.carRentalsQuery = carRentalsQuery;
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public JsonResult GetRentals()
        {
            var viewModel = this.carRentalsQuery.GetData();

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}