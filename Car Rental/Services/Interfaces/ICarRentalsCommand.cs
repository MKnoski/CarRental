using Car_Rental.Models;

namespace Car_Rental.Services.Interfaces
{
    public interface ICarRentalsCommand
    {
        void AddCarRental(RentalModel model);
    }
}