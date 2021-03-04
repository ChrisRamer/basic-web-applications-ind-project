using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsAndOrders.Models;

namespace VendorsAndOrdersTests
{
	[TestClass]
	public class VendorTests : IDisposable
	{
		string name = "some vendor";
		string description = "some description";

		public void Dispose()
		{
			Vendor.ClearAll();
		}

		[TestMethod]
		public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
		{
			Vendor newVendor = new Vendor(name, description);
			Assert.AreEqual(typeof(Vendor), newVendor.GetType());
		}

		[TestMethod]
		public void GetName_ReturnsName_String()
		{
			string name = "some vendor";
			Vendor newVendor = new Vendor(name, description);

			string result = newVendor.Name;

			Assert.AreEqual(name, result);
		}

		[TestMethod]
		public void GetId_ReturnsVendorId_Int()
		{
			Vendor newVendor = new Vendor(name, description);

			int result = newVendor.Id;

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void GetAll_ReturnsAllVendorObjects_VendorList()
		{
			Vendor newVendor1 = new Vendor(name, description);
			Vendor newVendor2 = new Vendor(name, description);
			List<Vendor> vendors = new List<Vendor> { newVendor1, newVendor2 };

			List<Vendor> result = Vendor.GetAll();

			CollectionAssert.AreEqual(vendors, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectVendor_Vendor()
		{
			Vendor newVendor1 = new Vendor(name, description);
			Vendor newVendor2 = new Vendor(name, description);
			List<Vendor> vendors = new List<Vendor> { newVendor1, newVendor2 };

			Vendor result = Vendor.Find(2);

			Assert.AreEqual(newVendor2, result);
		}

		[TestMethod]
		public void AddItem_AssociatesOrderWithVendor_OrderList()
		{
			Order newOrder = new Order("some order", "some description", 69, new DateTime(2021, 4, 4));
			List<Order> orders = new List<Order> { newOrder };
			Vendor newVendor = new Vendor(name, description);
			newVendor.AddOrder(newOrder);

			List<Order> result = newVendor.Orders;

			CollectionAssert.AreEqual(orders, result);
		}
	}
}