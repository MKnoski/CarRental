using Car_Rental.ViewModels;

namespace Car_Rental.Services.Interfaces
{
    public interface ICarRentalsQuery
    {
        CarRentalsViewModel GetCarRentals();
    }
}