
using lab_3_thien.Models;
using lab_3_thien.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_3_thien.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();

        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);

        }

        // GET: Courses
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModels viewModels)
        {
            if (!ModelState.IsValid)
            {
                viewModels.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModels);

            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModels.GetDateTime(),
                CategoryId = viewModels.Category,
                Place = viewModels.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index","Home");
        }
    }
}