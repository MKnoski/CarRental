using CarRental.Data.Models;

namespace CarRental.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.CarRentalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CarRental.Data.Context.CarRentalContext";
        }

        protected override void Seed(Context.CarRentalContext context)
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
                    Deposit = 500
                }
            );

            context.Cars.AddOrUpdate(
                new Car
                {
                    Type = "osobowy",
                    Brand = "Ford",
                    Model = "Fiesta",
                    RegistrationNumber = "DW A56O8",
                    Fuel = "benzynowy",
                    CarImageUrl = @"http://www.evanshalshaw.com/images/special-offers/new-cars/915789/946509/950906/fiesta-zetec-s-silver-main.jpg",
                    Transmission = "manualna",
                    Yearbook = 2016,
                    EngineCapacity = 1.0f,
                    NumberOfSeats = 4,
                    NumberOfDoors = 3,
                    FuelConsumption = 4.5f,
                    Power = 70,
                    AdditionalFeatures = "klimatyzacja",
                    PricePerDay = 550,
                    Deposit = 500
                }
            );

            context.Cars.AddOrUpdate(
                new Car
                {
                    Type = "osobowy",
                    Brand = "Seat",
                    Model = "Leon",
                    RegistrationNumber = "DW A56O7",
                    Fuel = "benzynowy",
                    CarImageUrl = @"http://img.chceauto.pl/arts/seat-leon-iii-oto-zdjecia-497-3177_v1.jpg",
                    Transmission = "manualna",
                    Yearbook = 2016,
                    EngineCapacity = 1.6f,
                    NumberOfSeats = 5,
                    NumberOfDoors = 5,
                    FuelConsumption = 5.5f,
                    Power = 90,
                    AdditionalFeatures = "klimatyzacja",
                    PricePerDay = 600,
                    Deposit = 500
                }
            );
        }
    }
}
