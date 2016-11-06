using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        public string Fuel { get; set; }

        public string Transmission { get; set; }

        public int NumberOfSeats { get; set; }

        public int NumberOfDoors { get; set; }

        [Required]
        public double PricePerDay { get; set; }

        public int Yearbook { get; set; }

        public float EngineCapacity { get; set; }

        public float FuelConsumption { get; set; }

        public int Power { get; set; }

        public string AdditionalFeatures { get; set; }

        public int Deposit { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

    }
}
