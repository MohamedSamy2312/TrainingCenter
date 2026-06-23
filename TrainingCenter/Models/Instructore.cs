using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingCenter.Models
{
    public class Instructore
    {
        public int Id { get; set; }

        [Display(Name="Instructore Name:")]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? Salary { get; set; }
        public string? Address { get; set; }

        [Display(Name = "Department: ")]
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        [Display(Name= "Course: ")]
        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }


    }
}
