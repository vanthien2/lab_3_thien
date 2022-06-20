using lab_3_thien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_3_thien.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}