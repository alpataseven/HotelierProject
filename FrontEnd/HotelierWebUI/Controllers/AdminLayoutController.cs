using Microsoft.AspNetCore.Mvc;

namespace HotelierWebUI.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult _AdminLayout()
		{
			return View();
		}
		public PartialViewResult HeadPartial()
		{
			return PartialView();
		}
	}
}
