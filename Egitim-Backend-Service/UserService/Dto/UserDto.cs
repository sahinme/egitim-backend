using System;
using Egitim_Backend_Service.Dto;

namespace Egitim_Backend_Service.UserService.Dto
{
    public class UserDto:EntityDto<long>
    {
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public byte Gender { get; set; }
        
        public int Age { get; set; }
        
        public string Profession { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
        
        public DateTime CreatedDate { get; set; }

    }
}