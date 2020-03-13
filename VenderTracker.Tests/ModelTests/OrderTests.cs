using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VenderTracker.Models;

namespace VenderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateOrder_Order()
    {
      Order order = new Order("title", "itemType", 2, 5.50, "dueDate");
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void OrderConstructor_InitializeOrderProperties_OrderProperties()
    {
      string title = "title";
      string type = "itemType";
      int amount = 2;
      double price = 5.50;
      string date = "dueDate";
      Order order = new Order(title, type, amount, price, date);
      Assert.AreEqual(title, order.Title);
      Assert.AreEqual(type, order.Type);
      Assert.AreEqual(amount, order.Amount);
      Assert.AreEqual(price, order.Price);
      Assert.AreEqual(date, order.Date);
    }

    [TestMethod]
    public void GetAll_GetAllOrders_OrderList()
    {
      Order order1 = new Order("title", "itemType", 2, 5.50, "dueDate");
      Order order2 = new Order("title2", "itemType2", 3, 3.50, "dueDate2");
      List<Order> expectedOrders = new List<Order> { order1, order2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(expectedOrders, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      Order order = new Order("title", "itemType", 2, 5.50, "dueDate");
      int result = order.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_FindSpecificORder_Order()
    {
      Order order1 = new Order("title", "itemType", 2, 5.50, "dueDate");
      Order order2 = new Order("title2", "itemType2", 3, 3.50, "dueDate2");
      Order result = Order.Find(2);
      Assert.AreEqual(order2, result);
    }
  }
}