using AutoMapper;
using PorcXarxaAPI.DTOs.Farms;
using PorcXarxaAPI.DTOs.Users;
using PorcXarxaAPI.Entities;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<CreateFarmDTO, Farm>();
        CreateMap<Farm, GetFarmDTO>();

        CreateMap<CreateUserDTO, User>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
        CreateMap<User, TokenUserDTO>();
        CreateMap<User, GetUserDTO>();
    }
}
