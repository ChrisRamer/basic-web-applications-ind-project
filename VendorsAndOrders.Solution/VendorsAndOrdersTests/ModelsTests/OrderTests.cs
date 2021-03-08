using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsAndOrders.Models;

namespace VendorsAndOrdersTests
{
	[TestClass]
	public class OrderTests : IDisposable
	{
		string name = "some order";
		string description = "some description";
		int price = 69;
		DateTime date = new DateTime(2021, 4, 4);

		public void Dispose()
		{
			Order.ClearAll();
		}

		[TestMethod]
		public void OrderConstructor_CreatesInstanceOfOrder_Order()
		{
			Order newOrder = new Order(name, description, price, date);
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}

		[TestMethod]
		public void GetDescription_ReturnsDescription_String()
		{
			Order newOrder = new Order(name, description, price, date);

			string result = newOrder.Description;

			Assert.AreEqual(description, result);
		}

		[TestMethod]
		public void GetAll_ReturnsOrders_OrderList()
		{
			Order newOrder1 = new Order(name, description, price, date);
			Order newOrder2 = new Order(name, description, price, date);
			List<Order> orders = new List<Order> { newOrder1, newOrder2 };

			List<Order> result = Order.GetAll();

			CollectionAssert.AreEqual(orders, result);
		}

		[TestMethod]
		public void GetId_OrderInstantiatesWithAnIDAndGetterReturns_Int()
		{
			Order newOrder = new Order(name, description, price, date);

			int result = newOrder.Id;

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectOrder_Order()
		{
			Order newOrder1 = new Order(name, description, price, date);
			Order newOrder2 = new Order("some order 2", "some description 2", 69420, new DateTime(2021, 3, 8));

			Order result = Order.Find(2);

			Assert.AreEqual(newOrder2, result);
		}
	}
}