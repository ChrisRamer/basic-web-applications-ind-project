using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorsAndOrders.Models;


namespace VendorsAndOrders.Controllers
{
	public class VendorsController : Controller
	{
		[HttpGet("/vendors")]
		public ActionResult Index()
		{
			List<Vendor> allVendors = Vendor.GetAll();
			return View(allVendors);
		}

		[HttpGet("/vendors/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/vendors")]
		public ActionResult Create(string name, string description)
		{
			Vendor newVendor = new Vendor(name, description);
			return RedirectToAction("Index");
		}

		[HttpGet("/vendors/{id}")]
		public ActionResult Show(int id)
		{
			Dictionary<string, object> model  =new Dictionary<string, object>();
			Vendor vendor = Vendor.Find(id);
			List<Order> orders  = vendor.Orders;
			model.Add("vendor", vendor);
			model.Add("orders", orders);
			return View(model);
		}
	}
}