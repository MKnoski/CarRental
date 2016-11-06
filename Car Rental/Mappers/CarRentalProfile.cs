using AutoMapper;
using CarRental.Data.DTOs;
using Car_Rental.ViewModels;

namespace Car_Rental.Mappers
{
    public class CarRentalProfile : Profile
    {
        public CarRentalProfile()
        {
            CreateMap<CarDto, CarViewModel>();
        }
    }
}