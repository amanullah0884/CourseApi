using CourseApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ApplicationUser _context;

        public string Image { get; private set; }

        public CourseController(ApplicationUser context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Courses.Include(c => c.Categories);
            return View(await applicationDbContext.ToListAsync());
        }

        private IActionResult View(List<Course> courses)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Pic(IFormFile Pic)
        {
            string msg = "";
            string rPath = "";
            string wwwRootPath = "";
            if (_context != null)
            {

            }


        }
    }
