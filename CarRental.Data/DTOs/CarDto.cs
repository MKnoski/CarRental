using System.Collections.Generic;
using CarRental.Data.Models;
using System;

namespace CarRental.Data.DTOs
{
    public class CarDto
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string CarImageUrl { get; set; }

        public string RegistrationNumber { get; set; }

        public string Fuel { get; set; }

        public string Transmission { get; set; }

        public int NumberOfSeats { get; set; }

        public int NumberOfDoors { get; set; }

        public double PricePerDay { get; set; }

        public int Yearbook { get; set; }

        public float EngineCapacity { get; set; }

        public float FuelConsumption { get; set; }

        public int Power { get; set; }

        public string AdditionalFeatures { get; set; }

        public int Deposit { get; set; }

        public IEnumerable<RentalDto> Rentals { get; set; }
    }
}