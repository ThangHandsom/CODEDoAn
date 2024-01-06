using DoAnLTWeb2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAnLTWeb2.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataContext _context;
        public AboutController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
