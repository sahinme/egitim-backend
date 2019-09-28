using System;
using Egitim_Backend.Core.Entities;

namespace Egitim_Backend.Entities.Concrete
{
    public class BaseEntity:IEntity
    {
        public long Id { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime ModifiedDate { get; set; }
        
        public string CreatorUserId { get; set; }
        
        public string ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }    
    }
}