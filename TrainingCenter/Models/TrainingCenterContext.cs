using Microsoft.EntityFrameworkCore;

namespace TrainingCenter.Models
{
    public class TrainingCenterContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructore> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .;" +
                                        "Database= TrainingCenterDb;" +
                                        "Integrated Security=True;" +
                                        "Trust Server Certificate=True"
                );
        }
    }
    
}
