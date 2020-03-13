using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VenderTracker.Models;

namespace VenderTracker.Tests
{
  [TestClass]
  public class VenderTests : IDisposable
  {

    public void Dispose()
    {
      Vender.ClearAll();
    }

    [TestMethod]
    public void VenderConstructor_CreateVender_Vender()
    {
      Vender vender = new Vender("name", "description");
      Assert.AreEqual(typeof(Vender), vender.GetType());
    }

    [TestMethod]
    public void VenderConstructor_InitializeProperties_VenderProperties()
    {
      string name = "name";
      string description = "description";
      List<Order> emptyList = new List<Order>() { };
      Vender vender = new Vender(name, description);
      Assert.AreEqual(name, vender.Name);
      Assert.AreEqual(description, vender.Description);
      Assert.AreEqual(emptyList, vender.Orders);
    }

    [TestMethod]
    public void GetId_ReturnVenderId_Int()
    {
      Vender vender = new Vender("name", "description");
      int result = vender.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnAllVenders_VenderList()
    {
      Vender vender1 = new Vender("name1", "description1");
      Vender vender2 = new Vender("name2", "description2");
      List<Vender> expectedList = new List<Vender> { vender1, vender2 };
      List<Vender> result = Vender.GetAll();
      CollectionAssert.AreEqual(expectedList, result);
    }

    [TestMethod]
    public void Find_ReturnSpecificVender_Vender()
    {
      Vender vender1 = new Vender("name1", "description1");
      Vender vender2 = new Vender("name2", "description2");
      Vender result = Vender.Find(2);
      Assert.AreEqual(vender2, result);
    }

    [TestMethod]
    public void AddOrder_AddOrderToSpecificVender_OrderList()
    {
      Order order = new Order("title", "itemType", 2, 5.50, "dueDate");
      List<Order> expectedOrders = new List<Order> { order };
      Vender vender = new Vender("name", "description");
      vender.AddOrder(order);
      List<Order> result = vender.Orders;
      CollectionAssert.AreEqual(expectedOrders, result);
    }
  }
}