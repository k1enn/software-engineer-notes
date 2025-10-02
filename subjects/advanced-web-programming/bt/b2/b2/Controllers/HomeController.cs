using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using b2.Models;

namespace b2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RsvpForm(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        else
        {
            return View();
        }
    }

    public IActionResult ListResponses(string course = "")
    {
        ViewBag.SelectedCourse = course;
        ViewBag.Courses = Repository.GetUniqueCourses();

        var attendees = Repository.GetAttendeesByCourse(course);
        return View(attendees);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
