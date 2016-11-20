using CarRental.Data.Services.Interfaces;

namespace Car_Rental.Services
{
    public abstract class CarRentalsServiceBase
    {
        protected readonly ICarRentalRepository Repository;

        protected CarRentalsServiceBase(ICarRentalRepository repository)
        {
            this.Repository = repository;
        }
    }
}