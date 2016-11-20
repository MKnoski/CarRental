using CarRental.Data.Context;
using CarRental.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
                var car = context.Cars
                    .Include(c => c.Rentals)
                    .FirstOrDefault(x => x.Id.Equals(id));
                var mappedCar = Mapper.Map<CarDto>(car);

                return mappedCar;
            }
        }

        public List<CarDto> GetCars()
        {
            using (var context = new CarRentalContext())
            {
                var cars =  context.Cars
                    .Include(c => c.Rentals)
                    .ToList();
                var mappedCars = Mapper.Map<List<CarDto>>(cars);

                return mappedCars;
            }
        }

        public void UpdateCustomer(CustomerDto customerDto)
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

        public void AddRental(RentalDto rentalDto)
        {
            var rental = Mapper.Map<Rental>(rentalDto);

            using (var context = new CarRentalContext())
            {
                context.Rentals.Add(rental);
                context.SaveChanges();
            }
        }
    }
}
