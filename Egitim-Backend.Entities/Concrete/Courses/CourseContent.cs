using Egitim_Backend.Entities.Concrete.Base;

namespace Egitim_Backend.Entities.Concrete.Courses
{
    public class CourseContent:BaseEntity
    {
        // Video veya gorsel olabilir.
        public string ContentPath { get; set; }
        
        // video, pdf, image
        public ContentType ContentType { get; set; }
    }
}