using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApi.Models
{
    public class CourseSection
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course  Course { get; set; }
    }
}
