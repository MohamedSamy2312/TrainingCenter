using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Models;

namespace TrainingCenter.Controllers
{
    public class CourseController : Controller
    {
        TrainingCenterContext context = new TrainingCenterContext();
        public IActionResult Index()
        {
            List<Course> courses = context.Courses.Include(d=> d.Department).ToList();
            return View("Index", courses);
        }
    }
}
