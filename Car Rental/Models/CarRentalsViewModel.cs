using System.Collections.Generic;

namespace Car_Rental.Models
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