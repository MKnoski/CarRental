using System.Collections.Generic;

namespace Car_Rental.ViewModels
{
    public class CarRentalViewModel
    {
        public CarRentalViewModel()
        {
            this.Car = new CarViewModel();
            this.Rentals = new List<RentalModel>();
        }

        public CarViewModel Car { get; set; }

        public List<RentalModel> Rentals { get; set; }
    }
}