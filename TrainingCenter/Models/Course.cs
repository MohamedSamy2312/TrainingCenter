using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingCenter.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Course: ")]
        public string Name { get; set; }

        [Display(Name = "Max Degree: ")]
        public int Degree { get; set; }

        [Display(Name = "Min Degree: ")]
        public int MinDegree { get; set; }
        
        public int Hours { get; set; }

        [Display(Name = "Department: ")]
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public List<Instructore> Instructors { get; set; }
        public List<CrsResult> Results { get; set; }
    }
}
