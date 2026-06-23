using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrainingCenter.Models;

namespace TrainingCenter.ViewModel.Instructore
{
    public class InstructoreWithListOfDepartAndCourseVM
    {
        public int Id { get; set; }

        [Display(Name = "Instructor Name:")]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? Salary { get; set; }
        public string? Address { get; set; }

        public int DeptId { get; set; }

        [Display(Name = "Department: ")]
        public string DeptName { get; set; }
        public Department Department { get; set; }

        public int CrsId { get; set; }

        [Display(Name="Course Name")]
        public string CrsName { get; set; }
        public Course Course { get; set; }
    }
}
