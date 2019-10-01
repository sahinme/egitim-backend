using System.ComponentModel.DataAnnotations.Schema;
using Egitim_Backend.Entities.Concrete.Base;
using Egitim_Backend.Entities.Concrete.Users;

namespace Egitim_Backend.Entities.Concrete.Courses
{
    public class FavoriteCourse:BaseEntity
    {
        public long UserId { get; set; }
        
        public long CourseId { get; set; }
        
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}