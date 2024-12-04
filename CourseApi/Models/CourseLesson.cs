using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models
{
    public class CourseLesson
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(150)]
        public string? Description { get; set; }
        [StringLength(150)]
        public string? VideoPath { get; set; }
        [NotMapped]
        public IFormFile? VideoFile { get; set; }
        
        [ForeignKey("CourseSection")]
        public int SectionId { get; set; }

    }
}
