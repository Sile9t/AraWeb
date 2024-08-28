using AutoMapper;
using Entities.Models;
using Shared.Dtos;

namespace AraWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Apartment, ApartmentDto>();
        }
    }
}
