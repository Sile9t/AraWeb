using AutoMapper;
using Entities.Models;
using Shared.Dtos;

namespace AraWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<UserForUpdateDto, User>();

            CreateMap<Apartment, ApartmentDto>();
            CreateMap<ApartmentForCreationDto, Apartment>();
            CreateMap<ApartmentForUpdateDto, Apartment>().ReverseMap();

            CreateMap<ReservationDate, ReservationDateDto>();
            CreateMap<ReservationDateForCreationDto, ReservationDate>();
            CreateMap<ReservationDateForUpdateDto, ReservationDate>();
        }
    }
}
