using System.Collections.Generic;

namespace Nuova_cartella.Models.ViewModels
{
    public class CourseDetailViewModel : CourseViewModel
    {
        public string Description {get; set;}

        public List<LessonViewModel> Lessons {get; set;}

    }
}