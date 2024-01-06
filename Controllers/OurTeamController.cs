using Microsoft.AspNetCore.Mvc;

namespace DoAnLTWeb2.Controllers
{
    public class OurTeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
