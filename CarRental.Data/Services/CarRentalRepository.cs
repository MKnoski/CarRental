using CarRental.Data.Context;
using CarRental.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using CarRental.Data.DTOs;
using CarRental.Data.Services.Interfaces;

namespace CarRental.Data.Services
{
    public class CarRentalRepository : ICarRentalRepository
    {
        public CarDto GetCar(int id)
        {
            using (var context = new CarRentalContext())
            {
                var car = context.Cars.FirstOrDefault(x => x.Id.Equals(id));
                var mappedCar = Mapper.Map<CarDto>(car);

                return mappedCar;
            }
        }

        public List<CarDto> GetCars()
        {
            using (var context = new CarRentalContext())
            {
                var cars =  context.Cars.ToList();
                var mappedCars = Mapper.Map<List<CarDto>>(cars);

                return mappedCars;
            }
        }

        public void SaveCar(CarDto carDto)
        {
            var car = Mapper.Map<Car>(carDto);

            using (var context = new CarRentalContext())
            {
                context.Cars.Attach(car);
                context.Entry(car).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddCar(CarDto carDto)
        {
            var car = Mapper.Map<Car>(carDto);

            using (var context = new CarRentalContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public void RemoveCar(CarDto carDto)
        {
            var car = Mapper.Map<Car>(carDto);

            using (var context = new CarRentalContext())
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }
        }

        public CustomerDto GetCustomer(int id)
        {
            using (var context = new CarRentalContext())
            {
                var customer = context.Customers.FirstOrDefault(x => x.Id.Equals(id));
                var mappedCustomer = Mapper.Map<CustomerDto>(customer);

                return mappedCustomer;
            }
        }

        public List<CustomerDto> GetCustomers()
        {
            using (var context = new CarRentalContext())
            {
                var customers = context.Customers.ToList();
                var mappedCustomer = Mapper.Map<List<CustomerDto>>(customers);

                return mappedCustomer;
            }
        }

        public void SaveCustomer(CustomerDto customerDto)
        {
            var customer = Mapper.Map<Customer>(customerDto);

            using (var context = new CarRentalContext())
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddCustomer(CustomerDto customerDto)
        {
            var customer = Mapper.Map<Customer>(customerDto);

            using (var context = new CarRentalContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void RemoveCustomer(CustomerDto customerDto)
        {
            var customer = Mapper.Map<Customer>(customerDto);

            using (var context = new CarRentalContext())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public RentalDto GetRental(int id)
        {
            using (var context = new CarRentalContext())
            {
                var rental = context.Rentals.FirstOrDefault(x => x.Id.Equals(id));
                var mappedRental = Mapper.Map<RentalDto>(rental);

                return mappedRental;
            }
        }

        public List<RentalDto> GetRentals()
        {
            using (var context = new CarRentalContext())
            {
                var rentals = context.Rentals.ToList();
                var mappedRentals = Mapper.Map<List<RentalDto>>(rentals);

                return mappedRentals;
            }
        }

        public void SaveRental(RentalDto rentalDto)
        {
            var rental = Mapper.Map<Rental>(rentalDto);

            using (var context = new CarRentalContext())
            {
                context.Rentals.Attach(rental);
                context.Entry(rental).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddRental(RentalDto rentalDto)
        {
            var rental = Mapper.Map<Rental>(rentalDto);

            using (var context = new CarRentalContext())
            {
                context.Rentals.Add(rental);
                context.SaveChanges();
            }
        }

        public void RemoveRental(RentalDto rentalDto)
        {
            var rental = Mapper.Map<Rental>(rentalDto);

            using (var context = new CarRentalContext())
            {
                context.Rentals.Remove(rental);
                context.SaveChanges();
            }
        }

    }
}
