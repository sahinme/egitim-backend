using System.ComponentModel.DataAnnotations.Schema;
using Egitim_Backend.Entities.Concrete.Base;

namespace Egitim_Backend.Entities.Concrete.Categories
{
    public class Category:BaseEntity
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }
        
        public long? ParentCategoryId { get; set; }
        
        
        [ForeignKey(nameof(ParentCategoryId))]
        public virtual Category ParentCategory { get; set; }
    }
}
