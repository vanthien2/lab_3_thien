using lab_3_thien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_3_thien.ViewModels
{
    public class CourseViewModels
    {
        public String Place { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }

        public Byte Category { get; set;}
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));

        }

    }
}