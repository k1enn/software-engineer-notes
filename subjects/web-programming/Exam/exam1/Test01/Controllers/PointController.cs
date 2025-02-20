using System.Linq;
using System.Web.Mvc;
using Test01.Models;

public class PointController : Controller
{
    private readonly PointManagementEntities _context;

    public PointController()
    {
        _context = new PointManagementEntities();
    }

    public ActionResult PointInfo(int? courseId)
    {
        // Tìm khóa học theo ID
        var course = _context.Courses.Find(courseId);
        if (course == null)
        {
            return HttpNotFound();
        }

        // Lấy danh sách sinh viên và điểm
        var students = _context.Students.Where(s => s.CourseID == courseId).ToList();
        var points = _context.Points.Where(p => p.CourseID == courseId).ToList();

        // Truyền dữ liệu vào ViewBag
        ViewBag.Course = course;
        ViewBag.Students = students;
        ViewBag.Points = points;

        return View();
    }
}
