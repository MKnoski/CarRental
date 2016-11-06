using AutoMapper;
using CarRental.Data.DTOs;
using CarRental.Data.Models;

namespace Car_Rental.Mappers
{
    public class DtoMappingsProfile : Profile
    {
        public DtoMappingsProfile()
        {
            base.CreateMap<Car, CarDto>().MaxDepth(1);
            base.CreateMap<CarDto, Car>().MaxDepth(1);
            base.CreateMap<CustomerDto, Customer>().MaxDepth(1);
            base.CreateMap<Customer, CustomerDto>().MaxDepth(1);
            base.CreateMap<Rental, RentalDto>().MaxDepth(1);
            base.CreateMap<RentalDto, Rental>().MaxDepth(1);
        }
    }
}