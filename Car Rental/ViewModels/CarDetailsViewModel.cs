using System.Collections.Generic;

namespace Car_Rental.ViewModels
{
    public class CarDetailsViewModel
    {
        public CarDetailsViewModel()
        {
            this.Rentals = new List<RentalViewModel>();
        }

        public IEnumerable<RentalViewModel> Rentals { get; set; }

        public int Yearbook { get; set; }

        public string Type { get; set; }

        public string RegistrationNumber { get; set; }

        public string Fuel { get; set; }

        public string Transmission { get; set; }

        public int NumberOfDoors { get; set; }

        public float FuelConsumption { get; set; }

        public string AdditionalFeatures { get; set; }

        public int Deposit { get; set; }
    }
}