namespace Egitim_Backend.Entities.Concrete.User
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public byte Gender { get; set; }
        
        public int Age { get; set; }
        
        //meslek
        public string Profession { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}