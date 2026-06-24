using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Models;
using TrainingCenter.ViewModel.Instructore;

namespace TrainingCenter.Controllers
{
    public class InstructoreController : Controller
    {
        TrainingCenterContext context = new TrainingCenterContext();

        //List<InstructoreWithListOfDepartAndCourseVM> getIstructorsData()
        //{
        //    List<Instructore> instructors = context.Instructors.ToList();
        //    List<Department> departments = context.Departments.ToList();
        //    List<Course> courses = context.Courses.ToList();

        //    List<InstructoreWithListOfDepartAndCourseVM> instrcturesForView = new();

        //    foreach (Instructore item in instructors)
        //    {
        //        instrcturesForView
        //            .Add(new InstructoreWithListOfDepartAndCourseVM()
        //            {
        //                Id = item.Id,
        //                Name = item.Name,
        //                Salary = item.Salary,
        //                Address = item.Address,
        //                ImageUrl = item.ImageUrl,
        //                DeptId = item.DeptId,
        //                DeptName = departments.FirstOrDefault
        //                            (d => d.Id == item.DeptId).Name,
        //                CrsId = item.CrsId,
        //                CrsName = courses.FirstOrDefault(c => c.Id == item.CrsId).Name
        //            });
        //    }
        //    return instrcturesForView;
        //}


        public IActionResult Index()
        {
            //List<Instructore> instructores = context.Instructors
            //        .Include(d => d.Department)
            //        .Include(c => c.Course)
            //        .ToList();

            return View("Index", context.Instructors
                    .Include(d => d.Department)
                    .Include(c => c.Course)
                    .ToList());
        }
        public IActionResult Details(int id)
        {
            return View("Details",
                context.Instructors.Include(d => d.Department)
                .Include(c => c.Course)
                .FirstOrDefault(i => i.Id == id));
        }
    }
}
