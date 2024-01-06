using DoAnLTWeb2.Models;
using Microsoft.AspNetCore.Mvc;


namespace DoAnLTWeb2.Controllers
{
    public class BookingController : Controller
    {
        private readonly DataContext _context;
        public BookingController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Booking model)
        {
            if (ModelState.IsValid)
            {
                // Lưu dữ liệu vào cơ sở dữ liệu
                _context.Bookings.Add(new Booking
                {
                    CusName = model.CusName,
                    Phone = model.Phone,
                    Email = model.Email,
                    OrderDate = model.OrderDate,
                    NumberOfPeople= model.NumberOfPeople,  
                    SpecialRequest = model.SpecialRequest  
                });
                _context.SaveChanges();

                // Sử dụng TempData để truyền thông điệp đến action "ThankYou"
                TempData["ThankYouMessage"] = "Cảm ơn bạn đã gửi tin nhắn! Chúng tôi sẽ sớm phản hồi cho bạn.";

                // Chuyển hướng người dùng sau khi gửi liên hệ
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
