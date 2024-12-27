using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineSchool.Data;
using OnlineSchool.Models;

namespace OnlineSchool.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }

        public async Task<IActionResult> Details(int id)
        {
            var course = await _context.Courses
                .Include(c => c.Lessons)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }
    }
}
