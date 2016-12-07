using System.Data.Entity;
using CarRental.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CarRental.Data.Context
{
    public class CarRentalContext : IdentityDbContext<ApplicationUser>
    {
        public CarRentalContext() 
            : base ("CarRental2")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static CarRentalContext Create()
        {
            return new CarRentalContext();
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<CustomerDetails> Customers { get; set; }
    }
}
