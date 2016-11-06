using Car_Rental.ViewModels;

namespace Car_Rental.Services.Interfaces
{
    public interface ICarRentalService
    {
        CarRentalsViewModel GetData();
    }
}