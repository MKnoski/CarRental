using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental.Data.Services.Interfaces;
using Car_Rental.ViewModels;

namespace Car_Rental.Controllers
{
    public class CarRentalController : Controller
    {
        private ICarRentalRepository repository;

        public CarRentalController(ICarRentalRepository carRentalRepository)
        {
            this.repository = carRentalRepository;
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public JsonResult GetRentals()
        {
            var viewModel = new CarRentalsViewModel
            {
                CarRentals = new List<CarRentalViewModel>
                {
                    new CarRentalViewModel
                    {
                        Car = new CarViewModel
                        {
                            Brand = "Golf",
                            PricePerDay = 100,
                            EngineCapacity = 1.3,
                            Yearbook = "1993",
                            NumberOfSeats = 4,
                            Type = "sportowe",
                            Model = "Trójka",
                            Power = 80
                        },
                        Rentals = new List<RentalModel>
                        {
                            new RentalModel {
                                StartDate = DateTime.Today,
                                EndDate = DateTime.Today.Add(TimeSpan.FromDays(5))
                            },
                            new RentalModel {
                                StartDate = DateTime.Today.Add(TimeSpan.FromDays(-8)),
                                EndDate = DateTime.Today.Add(TimeSpan.FromDays(-4))
                            }
                        }
                    },
                    new CarRentalViewModel
                    {
                        Car = new CarViewModel
                        {
                            Brand = "WolksVagen",
                            PricePerDay = 100,
                            EngineCapacity = 2.5,
                            Yearbook = "1993",
                            NumberOfSeats = 4,
                            Type = "sportowe",
                            Model = "6 GTI",
                            Power = 200
                        },
                        Rentals = new List<RentalModel>
                        {
                            new RentalModel {
                            StartDate = DateTime.Today.Add(TimeSpan.FromDays(1)),
                            EndDate = DateTime.Today.Add(TimeSpan.FromDays(3))
                            }
                        }
                    }
                }
            };
            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}