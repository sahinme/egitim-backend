using System.ComponentModel.DataAnnotations.Schema;
using Egitim_Backend.Entities.Concrete.Base;
using Egitim_Backend.Entities.Concrete.Educators;
using Egitim_Backend.Entities.Concrete.Tenants;


namespace Egitim_Backend.Entities.Concrete.Courses
{
    public class GivenCourse:BaseEntity
    {
        public long CourseId { get; set; }
        
        public long EducatorId { get; set; }

        public long? TenantId { get; set; }
        
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        
        [ForeignKey(nameof(EducatorId))]
        public virtual  Educator Educator { get; set; }
        
        [ForeignKey(nameof(TenantId))]
        public virtual  Tenant Tenant { get; set; }
    }
}