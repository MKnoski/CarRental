using System.Collections.Generic;

namespace Car_Rental.ViewModels
{
    public class CarRentalsViewModel
    {
        public CarRentalsViewModel()
        {
            this.CarRentals = new List<CarRentalViewModel>();
        }

        public IEnumerable<CarRentalViewModel> CarRentals { get; set; }
    }
}