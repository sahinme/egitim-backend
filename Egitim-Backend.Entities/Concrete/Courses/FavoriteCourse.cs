using System.ComponentModel.DataAnnotations.Schema;
using Egitim_Backend.Entities.Concrete.User;

namespace Egitim_Backend.Entities.Concrete.Course
{
    public class FavoriteCourse:BaseEntity
    {
        public long UserId { get; set; }
        
        public int CourseId { get; set; }
        
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User.User User { get; set; }
    }
}