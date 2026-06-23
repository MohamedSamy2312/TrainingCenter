using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingCenter.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        [Display(Name= "Trainee Name: ")]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Address { get; set; }
        public int? Grade { get; set; }

        [Display(Name = "Department")]
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public List<CrsResult> Results { get; set; }

    }
}
