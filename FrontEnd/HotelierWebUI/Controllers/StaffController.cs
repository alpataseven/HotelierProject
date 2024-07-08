using Microsoft.AspNetCore.Mvc;

namespace HotelierWebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
