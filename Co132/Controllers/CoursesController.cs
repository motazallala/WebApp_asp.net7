using Co132.Models;
using Microsoft.AspNetCore.Mvc;

namespace Co132.Controllers
{
    public class CoursesController : Controller
    {
        static List<Course> courses = new List<Course> {
            new Course {
            CourseId = 1,
            CourseName = "C++",
            CourseDescription ="programing language",
            Duration = "2 Week",
            EndDate = new DateTime(),
            IsPublished = true,
            Price = 500,
            StartDate = new DateTime()

        },
        new Course {
            CourseId = 2,
            CourseName = "Java",
            CourseDescription ="programing language",
            Duration = "4 Week",
            EndDate = new DateTime(),
            IsPublished = false,
            Price = 1000,
            StartDate = new DateTime()

        }

        };


        public IActionResult AllCourses()
        {
            return View(courses);
        }
        public IActionResult Derails(int? id)
        {
            if (id != null)
            {
                var course = (from data in courses where data.CourseId == id select data).FirstOrDefault();
                if (course != null)
                {
                    return View(course);
                }
                else
                {
                    return RedirectToAction("AllCourses");
                }
            }
            else
            {
                return RedirectToAction("AllCourses");
            }
        }
        [HttpGet]
        public IActionResult AddNewCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCourse(Course newCourse)
        {
            if (ModelState.IsValid)
            {
                courses.Add(newCourse);
                return RedirectToAction("AllCourses");

            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var delItem = (from data in courses
                               where data.CourseId == id
                               select data).FirstOrDefault();
                if (delItem != null)
                {
                    return View(delItem);
                }
                else
                {
                    return RedirectToAction("AllCourses");
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Course deletedCourse)
        {
            if (deletedCourse != null)
            {
                var delItem = (from data in courses
                               where data.CourseId == deletedCourse.CourseId
                               select data).FirstOrDefault();
                if (delItem != null)
                {
                    courses.Remove(delItem);
                    return RedirectToAction("AllCourses");
                }

            }
            return View();
        }
    }
}
