using Microsoft.AspNetCore.Mvc;

namespace DoAnLTWeb2.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
