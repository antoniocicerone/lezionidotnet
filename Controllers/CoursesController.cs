using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nuova_cartella.Models.Services.Application;
using Nuova_cartella.Models.ViewModels;

namespace Nuova_cartella.Controllers
{
    public class CoursesController : Controller
    {


        public IActionResult index() 
        {
            CourseService courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetCourses();
            return View(courses);
        }


        public IActionResult Detail(int id)
        {

            var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);


            return View();
        }

        
    }
}