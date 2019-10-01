using Egitim_Backend.Entities.Concrete.Base;

namespace Egitim_Backend.Entities.Concrete.Tenants
{
    public class Tenant:BaseEntity
    {
        public bool IsPremium { get; set; }

        public string Password { get; set; }
        
        public string TenantName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneNumber2 { get; set; }

        public string LogoPath { get; set; }    
    }
}