using lab_3_thien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab_3_thien.ViewModels
{
    public class CourseViewModels
    {
        [Required]
        public String Place { get; set; }
        [Required]
        [FutureDate]
        public String Date { get; set; }
        [Required]
        [ValidTime]
        public String Time { get; set; }
        [Required]
        public Byte Category { get; set;}
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));

        }

    }
}