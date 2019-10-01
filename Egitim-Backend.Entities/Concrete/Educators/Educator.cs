using System.ComponentModel.DataAnnotations.Schema;
using Egitim_Backend.Entities.Concrete.Base;
using Egitim_Backend.Entities.Concrete.Tenants;

namespace Egitim_Backend.Entities.Concrete.Educators
{
    public class Educator:BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Profession { get; set; }

        //Kisa ozgecmis bilgileri
        public string Resume { get; set; }

        public string ProfileImagePath { get; set; }
        public long? TenantId { get; set; }
        
        [ForeignKey(nameof(TenantId))]
        public virtual Tenant Tenant { get; set; }
        
    }
}