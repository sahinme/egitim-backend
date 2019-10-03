using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete.Users;
using Egitim_Backend_Service.Dto;
using Egitim_Backend_Service.UserService.Dto;
using Microsoft.EntityFrameworkCore;

namespace Egitim_Backend_Service.UserService
{
    public class UserAppService:IUserAppService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserAppService(
            IUserRepository userRepository,
            IMapper mapper
            )
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public async Task Add(CreateUserDto input)
        {
            var user = new User
            {
                Name = input.Name,
                Surname = input.Surname,
                EmailAddress = input.EmailAddress,
                Password = input.Password,
                Profession = input.Profession,
                Gender = input.Gender,
                Username = input.Username,
                Age = input.Age,
                PhoneNumber = input.PhoneNumber
            };
            await _userRepository.AddAsync(user);

        }

        public async Task<UserDto> GetById(long id)
        {
            var user = await _userRepository.GetAll().Where(p => p.Id == id).Select(p => new UserDto
            {
                Id = p.Id
            }).FirstOrDefaultAsync();

            return user;
        }
    }
}