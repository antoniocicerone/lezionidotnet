using System;
using System.Collections.Generic;
using Nuova_cartella.Models.ViewModels;

namespace Nuova_cartella.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {

            var courseList = new List<CourseViewModel>();
            for (int i = 0; i < 20; i++)
            {
                var course = new CourseViewModel 
                {
                    Id = i,
                    Title = $"Corso {i}",
                    Author = "Nome Cognome"
                };

                courseList.Add(course);
            }

            return courseList;
        }
    }
}