using AutoMapper;
using Egitim_Backend.Entities.Concrete.Users;
using Egitim_Backend_Service.UserService.Dto;

namespace Egitim_Backend_Service.MappingConfiguration
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<User, CreateUserDto>();
        }
    }
}