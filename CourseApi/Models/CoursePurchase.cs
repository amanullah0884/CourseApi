using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models
{
    public class CoursePurchase
    {
        public int Id { get; set; }

      
        [Required]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Purchase price must be a positive value.")]
        public double PurchasePrice { get; set; }
        
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Access duration must be a positive value.")]
        public double AccessDuration { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
