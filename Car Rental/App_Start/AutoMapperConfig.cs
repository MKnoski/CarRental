using AutoMapper;
using Car_Rental.Mappers;

namespace Car_Rental
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new CarRentalProfile());
                cfg.AddProfile(new DtoMappingsProfile());
            });
        }
    }
}