using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorsAndOrders.Models;

namespace VendorsAndOrders.Controllers
{
	public class OrdersController : Controller
	{
		[HttpGet("/vendors/{vendorId}/orders/new")]
		public ActionResult New(int vendorId)
		{
			Vendor vendor = Vendor.Find(vendorId);
			return View(vendor);
		}

		[HttpPost("/vendors/{id}")]
		public ActionResult Create(int id, string title, string description, int price, DateTime date)
		{
			Order newOrder = new Order(title, description, price, date);
			Vendor vendor = Vendor.Find(id);
			vendor.AddOrder(newOrder);
			return RedirectToAction("Show", "Vendors");
		}

		[HttpGet("vendors/{vendorId}/orders/{orderId}")]
		public ActionResult Show(int vendorId, int orderId)
		{
			Vendor vendor = Vendor.Find(vendorId);
			Order order = Order.Find(orderId);
			Dictionary<string, object> model = new Dictionary<string, object>();
			model.Add("vendor", vendor);
			model.Add("order", order);
			return View(model);
		}
	}
}