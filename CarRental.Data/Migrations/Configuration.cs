using CarRental.Data.Models;

namespace CarRental.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarRental.Data.Context.CarRentalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CarRental.Data.Context.CarRentalContext";
        }

        protected override void Seed(CarRental.Data.Context.CarRentalContext context)
        {
            context.Cars.AddOrUpdate(
                new Car
                {
                    Type = "osobowy",
                    Brand = "Fiat",
                    Model = "500",
                    RegistrationNumber = "DW A56O9",
                    Fuel = "benzynowy",
                    CarImageUrl = @"http://motozine.pl/wp-content/uploads/2015/07/2fiat5002016.jpg",
                    Transmission = "manualna",
                    Yearbook = 2015,
                    EngineCapacity = 1.2f,
                    NumberOfSeats = 4,
                    NumberOfDoors = 3,
                    FuelConsumption = 4.5f,
                    Power = 65,
                    AdditionalFeatures = "klimatyzacja",
                    PricePerDay = 500,
                    Deposit = 50
                }
            );
        }
    }
}
