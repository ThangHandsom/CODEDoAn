using Microsoft.AspNetCore.Mvc;
using DoAnLTWeb2.Utilities;

namespace DoAnLTWeb2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/file-manager")]
    public class FileManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
