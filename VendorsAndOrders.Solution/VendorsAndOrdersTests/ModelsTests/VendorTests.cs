using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsAndOrders.Models;

namespace VendorsAndOrdersTests
{
	[TestClass]
	public class VendorTests : IDisposable
	{
		public void Dispose()
		{
			Vendor.ClearAll();
		}

		[TestMethod]
		public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
		{
			Vendor newVendor = new Vendor("some vendor", "some description");
			Assert.AreEqual(typeof(Vendor), newVendor.GetType());
		}

		[TestMethod]
		public void GetName_ReturnsName_String()
		{
			string name = "some vendor";
			Vendor newVendor = new Vendor(name, "some description");

			string result = newVendor.Name;

			Assert.AreEqual(name, result);
		}

		[TestMethod]
		public void GetId_ReturnsVendorId_Int()
		{
			Vendor newVendor = new Vendor("some vendor", "some description");

			int result = newVendor.Id;

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void GetAll_ReturnsAllVendorObjects_VendorList()
		{
			Vendor newVendor1 = new Vendor("vendor1", "some description");
			Vendor newVendor2 = new Vendor("vendor2", "some description");
			List<Vendor> vendors = new List<Vendor> { newVendor1, newVendor2 };

			List<Vendor> result = Vendor.GetAll();

			CollectionAssert.AreEqual(vendors, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectVendor_Vendor()
		{
			Vendor newVendor1 = new Vendor("vendor1", "some description");
			Vendor newVendor2 = new Vendor("vendor2", "some description");
			List<Vendor> vendors = new List<Vendor> { newVendor1, newVendor2 };

			Vendor result = Vendor.Find(2);

			Assert.AreEqual(newVendor2, result);
		}

		[TestMethod]
		public void AddItem_AssociatesOrderWithVendor_OrderList()
		{
			Order newOrder = new Order("some order", "some description", 69, "3/1/2021");
			List<Order> orders = new List<Order> { newOrder };
			Vendor newVendor = new Vendor("some vendor", "some description");
			newVendor.AddOrder(newOrder);

			List<Order> result = newVendor.Orders;

			CollectionAssert.AreEqual(orders, result);
		}
	}
}