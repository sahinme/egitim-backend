using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Egitim_Backend.Entities.Concrete.Users;

namespace Egitim_Backend_Service.UserService.Dto
{
    public class CreateUserDto
    { 
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public char Gender { get; set; }
        
        public int Age { get; set; }
        
        //meslek
        public string Profession { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
        
    }
}