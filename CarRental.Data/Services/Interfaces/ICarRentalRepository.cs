using System.Collections.Generic;
using CarRental.Data.DTOs;
using System;

namespace CarRental.Data.Services.Interfaces
{
    public interface ICarRentalRepository
    {
        CarDto GetCar(Guid id);
        List<CarDto> GetCars();
        void UpdateCustomer(CustomerDetailsDto customerDetailsDto);
        void AddCustomer(CustomerDetailsDto customerDetailsDto);
        void AddRental(RentalDto rentalDto);
    }
}