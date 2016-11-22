using AutoMapper;
using CarRental.Data.DTOs;
using CarRental.Data.Models;
using Car_Rental.ViewModels;

namespace Car_Rental.Mappers
{
    public class DtoMappingsProfile : Profile
    {
        public DtoMappingsProfile()
        {
            base.CreateMap<Car, CarDto>();
            base.CreateMap<CarDto, Car>();
            base.CreateMap<CustomerDto, Customer>();
            base.CreateMap<Customer, CustomerDto>();
            base.CreateMap<Rental, RentalDto>();
            base.CreateMap<RentalDto, Rental>();
            base.CreateMap<RegisterViewModel, CustomerDto>();
        }
    }
}