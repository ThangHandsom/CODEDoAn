using Microsoft.AspNetCore.Mvc;

namespace DoAnLTWeb2.Controllers
{
    public class OurBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
