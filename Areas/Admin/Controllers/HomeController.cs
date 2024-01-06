using DoAnLTWeb2.Models;
using DoAnLTWeb2.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnLTWeb2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {

		private readonly DataContext _context;

		public HomeController(DataContext context)
		{
			_context = context;
		}
		public IActionResult Index()//đăng nhập
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
			var dataContext = _context.Products.Include(p => p.CateProduct);
            return View(dataContext);
        }
        public IActionResult Logout()//Đăng xuất
        {
            Functions._UserID = 0;
            Functions._UserName = string.Empty;
            Functions._Email = string.Empty;
            Functions._Message = string.Empty;
            Functions._MessageEmail = string.Empty;

            return RedirectToAction("Index", "Home");
        }
    }
}
