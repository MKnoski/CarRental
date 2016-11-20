using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRental.Data.Services.Interfaces;
using Car_Rental.ViewModels;
using CarRental.Data.Context;
using CarRental.Data.Services;
using Car_Rental.Models;
using Car_Rental.Services.Interfaces;

namespace Car_Rental.Controllers
{
    [Authorize]
    public class CarRentalController : Controller
    {
        private readonly ICarRentalsQuery carRentalsQuery;
        private readonly ICarRentalsCommand carRentalsCommand;

        public CarRentalController(ICarRentalsQuery carRentalsQuery, ICarRentalsCommand carRentalsCommand)
        {
            this.carRentalsQuery = carRentalsQuery;
            this.carRentalsCommand = carRentalsCommand;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [AllowAnonymous]
        public JsonResult GetRentals()
        {
            var viewModel = this.carRentalsQuery.GetCarRentals();

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddRental(RentalModel model)
        {
            this.carRentalsCommand.AddCarRental(model);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}