using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Car_Rental.Resources;

namespace Car_Rental.ViewModels
{
    public class CarViewModel
    {
        [Display(Name = "TypeLabel", ResourceType = typeof(CarRentalResource))]
        public string Type { get; set; }

        [Display(Name = "BrandLabel", ResourceType = typeof(CarRentalResource))]
        public string Brand { get; set; }

        [Display(Name = "ModelLabel", ResourceType = typeof(CarRentalResource))]
        public string Model { get; set; }

        [Display(Name = "NumberOfSeatsLabel", ResourceType = typeof(CarRentalResource))]
        public int NumberOfSeats { get; set; }

        [Display(Name = "PricePerDayLabel", ResourceType = typeof(CarRentalResource))]
        public double PricePerDay { get; set; }

        [Display(Name = "YearbookLabel", ResourceType = typeof(CarRentalResource))]
        public string Yearbook { get; set; }

        [Display(Name = "EngineCapacityLabel", ResourceType = typeof(CarRentalResource))]
        public double EngineCapacity { get; set; }

        public int Power { get; set; }
    }
}