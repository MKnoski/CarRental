using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Car_Rental.Resources;

namespace Car_Rental.ViewModels
{
    public class CarViewModel
    {
        public CarViewModel()
        {
            this.CarDetails = new CarDetailsViewModel();
        }

        public int Id { get; set; }

        public string CarImageUrl { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public double PricePerDay { get; set; }

        public float EngineCapacity { get; set; }

        public int Power { get; set; }

        public CarDetailsViewModel CarDetails { get; set; }
    }
}