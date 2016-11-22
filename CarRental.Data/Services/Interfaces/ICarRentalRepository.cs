using System.Collections.Generic;
using CarRental.Data.DTOs;

namespace CarRental.Data.Services.Interfaces
{
    public interface ICarRentalRepository
    {
        CarDto GetCar(int id);
        List<CarDto> GetCars();
        void UpdateCustomer(CustomerDetailsDto customerDetailsDto);
        void AddCustomer(CustomerDetailsDto customerDetailsDto);
        void AddRental(RentalDto rentalDto);
    }
}