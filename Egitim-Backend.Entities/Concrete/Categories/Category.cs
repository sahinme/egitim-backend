using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Egitim_Backend.Core.Entities;

namespace Egitim_Backend.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }
        
        public int? ParentCategoryId { get; set; }
        
        
        [ForeignKey(nameof(ParentCategoryId))]
        public virtual Category ParentCategory { get; set; }
    }
}
