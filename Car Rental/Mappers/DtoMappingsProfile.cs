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
            base.CreateMap<CustomerDetailsDto, CustomerDetails>();
            base.CreateMap<CustomerDetails, CustomerDetailsDto>();
            base.CreateMap<Rental, RentalDto>();
            base.CreateMap<RentalDto, Rental>();
            base.CreateMap<RegisterViewModel, CustomerDetails>();
        }
    }
}