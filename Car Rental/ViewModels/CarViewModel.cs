using System.ComponentModel;

namespace Car_Rental.ViewModels
{
    // TODO wjebać labelki do resourcow
    public class CarViewModel
    {
        [DisplayName("Typ")]
        public string Type { get; set; }

        [DisplayName("Marka")]
        public string Brand { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Ilość miejsc")]
        public int NumberOfSeats { get; set; }

        [DisplayName("Cena")]
        public double PricePerDay { get; set; }

        [DisplayName("Rocznik")]
        public string Yearbook { get; set; }

        [DisplayName("Silnik")]
        public double EngineCapacity { get; set; }

        public int Power { get; set; }
    }
}