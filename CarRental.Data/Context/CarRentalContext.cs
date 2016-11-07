using System.Data.Entity;
using CarRental.Data.Models;

namespace CarRental.Data.Context
{
    public class CarRentalContext : DbContext 
    {
        public CarRentalContext() 
            : base ("CarRental")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
