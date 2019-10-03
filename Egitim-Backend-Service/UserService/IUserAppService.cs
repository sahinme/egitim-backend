using System.Collections.Generic;
using System.Threading.Tasks;
using Egitim_Backend.Entities.Concrete.Users;
using Egitim_Backend_Service.Dto;
using Egitim_Backend_Service.UserService.Dto;

namespace Egitim_Backend_Service.UserService
{
    public interface IUserAppService
    {
        Task Add(CreateUserDto input);

        Task<UserDto> GetById(long id);
    }
}