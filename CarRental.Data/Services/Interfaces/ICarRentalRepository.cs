using System.Collections.Generic;
using CarRental.Data.DTOs;
using CarRental.Data.Models;

namespace CarRental.Data.Services.Interfaces
{
    public interface ICarRentalRepository
    {
        CarDto GetCar(int id);
        List<CarDto> GetCars();
        void UpdateCustomer(CustomerDto customerDto);
        void AddCustomer(CustomerDto customerDto);
        void AddRental(RentalDto rentalDto);
    }
}