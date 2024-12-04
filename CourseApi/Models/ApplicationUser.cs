using Microsoft.EntityFrameworkCore;

namespace CourseApi.Models
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions options) : base(options)
        {

        }
            public DbSet<Categories> Categories { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<CourseInstructor> CourseInstructors { get; set; }
            public DbSet<CourseLesson> CourseLessons { get; set; }
            public DbSet<CoursePurchase> CoursePurchases { get; set; }
            public DbSet<CourseSection> CoourseSections { get; set; }
            public DbSet<Instructor> instructors { get; set; }
            public DbSet<PaymentMethod> PaymentMethods { get; set; }

        }
    }

