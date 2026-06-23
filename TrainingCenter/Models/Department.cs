using System.ComponentModel.DataAnnotations;

namespace TrainingCenter.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name ="Department")]
        public string Name { get; set; }
        public string? Manager { get; set; }

        public List<Instructore> Instructors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Trainee> Trainee { get; set; }
    }
}
