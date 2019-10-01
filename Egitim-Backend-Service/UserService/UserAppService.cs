using System.Threading.Tasks;
using AutoMapper;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete.Users;
using Egitim_Backend_Service.UserService.Dto;

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
        
        public void Add(CreateUserDto input)
        {
            var user = _mapper.Map<User>(input);
            _userRepository.Add(user);
            
//            var user = new User
//            {
//                Name = input.Name,
//                EmailAddress = input.EmailAddress,
//                Password = input.Password
//            };
//            _userRepository.Add(user);
        }
    }
}