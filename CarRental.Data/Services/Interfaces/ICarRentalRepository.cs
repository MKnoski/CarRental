using System.Collections.Generic;
using CarRental.Data.DTOs;
using CarRental.Data.Models;

namespace CarRental.Data.Services.Interfaces
{
    public interface ICarRentalRepository
    {
        CarDto GetCar(int id);
        List<CarDto> GetCars();
        void UpdateCar(CarDto carDto);
        void AddCar(CarDto carDto);
        void RemoveCar(CarDto carDto);
        CustomerDto GetCustomer(int id);
        List<CustomerDto> GetCustomers();
        void UpdateCustomer(CustomerDto customerDto);
        void AddCustomer(CustomerDto customerDto);
        void RemoveCustomer(CustomerDto customerDto);
        RentalDto GetRental(int id);
        List<RentalDto> GetRentals();
        void UpdateRental(RentalDto rentalDto);
        void AddRental(RentalDto rentalDto);
        void RemoveRental(RentalDto rentalDto);
    }
}