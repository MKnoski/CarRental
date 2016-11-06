﻿using AutoMapper;
using CarRental.Data.DTOs;
using Car_Rental.ViewModels;

namespace Car_Rental.Mappers
{
    public class ViewModelsMappingProfile : Profile
    {
        public ViewModelsMappingProfile()
        {
            CreateMap<CarDto, CarViewModel>().ForMember(dest => dest.CarDetails, m => m.MapFrom(src => src));
            CreateMap<CarDto, CarDetailsViewModel>();
            CreateMap<RentalDto, RentalViewModel>();
            // CreateMap<CarDto, CarDetailsViewModel>().ForMember(dest => dest.Rentals, m => m.MapFrom(src => src.Rentals));
        }
    }
}