using DoAnLTWeb2.Areas.Admin.Models;
using DoAnLTWeb2.Models;
using DoAnLTWeb2.Utilities;
using Microsoft.AspNetCore.Mvc;


namespace DoAnLTWeb2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfileController : Controller
    {
        public IActionResult Index()//đăng nhập
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            return View();
        }
    }
}
