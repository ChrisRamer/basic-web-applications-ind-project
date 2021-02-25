using Microsoft.AspNetCore.Mvc;

namespace VendorsAndOrders.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
	}
}