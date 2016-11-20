using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CarRental.Data.Services.Interfaces;
using Car_Rental.Services.Interfaces;
using Car_Rental.ViewModels;

namespace Car_Rental.Services
{
    public class CarRentalsQuery : CarRentalsServiceBase, ICarRentalsQuery
    {
        public CarRentalsQuery(ICarRentalRepository repository) 
            : base(repository)
        {
        }

        public CarRentalsViewModel GetCarRentals()
        {
            var cars = base.Repository.GetCars();

            var carRentals = cars
                .Select(car => new CarRentalViewModel
                {
                    Car = Mapper.Map<CarViewModel>(car)
                })
                .ToList();

            var viewModel = new CarRentalsViewModel
            {
                CarRentals = carRentals
            };

            return viewModel;
        }
    }
}