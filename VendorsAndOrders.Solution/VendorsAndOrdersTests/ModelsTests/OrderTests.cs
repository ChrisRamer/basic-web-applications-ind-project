using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsAndOrders.Models;

namespace VendorsAndOrdersTests
{
	[TestClass]
	public class OrderTests : IDisposable
	{
		public void Dispose()
		{
			Order.ClearAll();
		}

		[TestMethod]
		public void OrderConstructor_CreatesInstanceOfOrder_Order()
		{
			Order newOrder = new Order("some order", "some description", 69, "3/1/2021");
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}

		[TestMethod]
		public void GetDescription_ReturnsDescription_String()
		{
			string description = "some description";
			Order newOrder = new Order("some order", description, 69, "3/1/2021");

			string result = newOrder.Description;

			Assert.AreEqual(description, result);
		}

		[TestMethod]
		public void GetAll_ReturnsOrders_OrderList()
		{
			Order newOrder1 = new Order("some order", "some description", 69, "3/1/2021");
			Order newOrder2 = new Order("some order", "some description", 69, "3/1/2021");
			List<Order> orders = new List<Order> { newOrder1, newOrder2 };

			List<Order> result = Order.GetAll();

			CollectionAssert.AreEqual(orders, result);
		}

		[TestMethod]
		public void GetId_OrderInstantiatesWithAnIDAndGetterReturns_Int()
		{
			Order newOrder = new Order("some order", "some description", 69, "3/1/2021");

			int result = newOrder.Id;

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectOrder_Order()
		{
			Order newOrder1 = new Order("some order", "some description", 69, "3/1/2021");
			Order newOrder2 = new Order("some order", "some description", 69, "3/1/2021");

			Order result = Order.Find(2);

			Assert.AreEqual(newOrder2, result);
		}
	}
}