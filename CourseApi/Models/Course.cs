using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApi.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Categories")]
        public int CateID { get; set; }
        public virtual Categories Categories { get; set; }

        public string? Image { get; set; }
        [NotMapped]
        public IFormFile Pic { get; set; }
    }
}
