using System.Net;
using System.Web.Mvc;
using Car_Rental.Models;
using Car_Rental.Services.Interfaces;
using Microsoft.AspNet.Identity;

namespace Car_Rental.Controllers
{
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
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public JsonResult GetRentals()
        {
            var viewModel = this.carRentalsQuery.GetCarRentals();
            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddRental(RentalModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                HttpContext.Items["SuppressAuthenticationKey"] = true;
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }

            var userId = this.User.Identity.GetUserId();
            model.ApplicationUserId = userId;

            this.carRentalsCommand.AddCarRental(model);
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}