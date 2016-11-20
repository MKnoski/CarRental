using AutoMapper;
using CarRental.Data.DTOs;
using Car_Rental.Models;
using Car_Rental.Services.Interfaces;
using CarRental.Data.Services.Interfaces;
using Car_Rental.ViewModels;

namespace Car_Rental.Services
{
    public class CarRentalsCommand : CarRentalsServiceBase, ICarRentalsCommand
    {
        public CarRentalsCommand(ICarRentalRepository repository) 
            : base(repository)
        {
        }

        public void AddCarRental(RentalModel model)
        {
            var rentalDto = Mapper.Map<RentalDto>(model);

            base.Repository.AddRental(rentalDto);
        }
    }
}