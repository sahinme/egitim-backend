namespace Egitim_Backend.Entities.Concrete
{
    public class CourseContent:BaseEntity
    {
        // Video veya gorsel olabilir.
        public string ContentPath { get; set; }
        
        // video, pdf, image
        public ContentType ContentType { get; set; }
    }
}