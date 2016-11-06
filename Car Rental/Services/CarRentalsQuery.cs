using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CarRental.Data.Services.Interfaces;
using Car_Rental.Services.Interfaces;
using Car_Rental.ViewModels;

namespace Car_Rental.Services
{
    public class CarRentalsQuery : ICarRentalsQuery
    {
        private readonly ICarRentalRepository repository;

        public CarRentalsQuery(ICarRentalRepository repository)
        {
            this.repository = repository;
        }

        public CarRentalsViewModel GetData()
        {
            var cars = this.repository.GetCars();

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