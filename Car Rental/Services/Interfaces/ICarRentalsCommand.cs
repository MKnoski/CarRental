using Car_Rental.Models;
using Car_Rental.ViewModels;

namespace Car_Rental.Services.Interfaces
{
    public interface ICarRentalsCommand
    {
        void AddCarRental(RentalModel model);
        void AddCustomer(RegisterViewModel model);
    }
}