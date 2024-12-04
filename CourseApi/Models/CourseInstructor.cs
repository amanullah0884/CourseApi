using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApi.Models
{
    public class CourseInstructor
    {
        public int Id { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Instructor")]
        public int InstID { get; set; }
        public virtual Course Course { get; set; }
         public virtual Instructor Instructor { get; set; }
       
      
    }
}
