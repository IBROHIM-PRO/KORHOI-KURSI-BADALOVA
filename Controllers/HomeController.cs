using Microsoft.AspNetCore.Mvc;
using OnlineSchool.Data;
using OnlineSchool.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace OnlineSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                PopularCourses = await _context.Courses
                    .OrderByDescending(c => c.CreatedAt)
                    .Take(6)
                    .ToListAsync()
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
