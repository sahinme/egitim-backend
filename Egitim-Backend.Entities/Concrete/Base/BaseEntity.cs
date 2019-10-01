using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Egitim_Backend.Core.Entities;

namespace Egitim_Backend.Entities.Concrete.Base
{
    public class BaseEntity:IEntity
    {
        [Key]
        public long Id { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime ModifiedDate { get; set; }
        
        public string CreatorUserId { get; set; }
        
        public string ModifiedBy { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }    
    }
}