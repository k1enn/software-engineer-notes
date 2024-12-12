using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test01.Models;

namespace Test01.Controllers
{
    public class HomeController : Controller
    {
        private PointManagementEntities db = new PointManagementEntities();

        public ActionResult Index()
        {
            var courses = db.Courses.ToList();
            return View(courses);
        }

        public ActionResult PointInfo()
        {
            var courses = db.Courses.ToList();
            return View(courses);
        }
    }

}