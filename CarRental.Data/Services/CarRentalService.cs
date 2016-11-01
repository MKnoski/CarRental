using CarRental.Data.Context;
using CarRental.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.Data.Services
{
    public static class CarRentalService
    {
        public static Car GetCar(int id)
        {
            using (var context = new CarRentalContext())
            {
                return context.Cars.FirstOrDefault(x => x.Id.Equals(id));
            }
        }

        public static List<Car> GetCars()
        {
            using (var context = new CarRentalContext())
            {
                return context.Cars.ToList();
            }
        }
        public static void SaveCar(Car car)
        {
            using (var context = new CarRentalContext())
            {
                context.Cars.Attach(car);
                context.Entry(car).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void AddCar(Car car)
        {
            using (var context = new CarRentalContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public static void RemoveCar(Car car)
        {
            using (var context = new CarRentalContext())
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }
        }

        public static Customer GetCustomer(int id)
        {
            using (var context = new CarRentalContext())
            {
                return context.Customers.FirstOrDefault(x => x.Id.Equals(id));
            }
        }

        public static List<Customer> GetCustomers()
        {
            using (var context = new CarRentalContext())
            {
                return context.Customers.ToList();
            }
        }

        public static void SaveCustomer(Customer customer)
        {
            using (var context = new CarRentalContext())
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void AddCustomer(Customer customer)
        {
            using (var context = new CarRentalContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public static void RemoveCustomer(Customer customer)
        {
            using (var context = new CarRentalContext())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public static Rental GetRental(int id)
        {
            using (var context = new CarRentalContext())
            {
                return context.Rentals.FirstOrDefault(x => x.Id.Equals(id));
            }
        }

        public static List<Rental> GetRentals()
        {
            using (var context = new CarRentalContext())
            {
                return context.Rentals.ToList();
            }
        }

        public static void SaveRental(Rental rental)
        {
            using (var context = new CarRentalContext())
            {
                context.Rentals.Attach(rental);
                context.Entry(rental).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void AddRental(Rental rental)
        {
            using (var context = new CarRentalContext())
            {
                context.Rentals.Add(rental);
                context.SaveChanges();
            }
        }

        public static void AddRental(Rental rental, Car car, Customer customer)
        {
            rental.Car = car;
            rental.CarId = car.Id;
            rental.Customer = customer;
            rental.CustomerId = customer.Id;

            using (var context = new CarRentalContext())
            {
                context.Rentals.Add(rental);
                context.SaveChanges();
            }
        }

        public static void RemoveRental(Rental rental)
        {
            using (var context = new CarRentalContext())
            {
                context.Rentals.Remove(rental);
                context.SaveChanges();
            }
        }

    }
}
