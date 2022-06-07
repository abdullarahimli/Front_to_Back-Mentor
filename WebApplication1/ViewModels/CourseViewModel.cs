using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CourseViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Course> Courses { get; set; }
        public List<Trainer> Trainers { get; set; }
    }
}
