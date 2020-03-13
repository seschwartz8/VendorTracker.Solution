using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateVendor_Vendor()
    {
      Vendor vendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_InitializeProperties_VendorProperties()
    {
      string name = "name";
      string description = "description";
      List<Order> emptyList = new List<Order>() { };
      Vendor vendor = new Vendor(name, description);
      Assert.AreEqual(name, vendor.Name);
      Assert.AreEqual(description, vendor.Description);
      CollectionAssert.AreEqual(emptyList, vendor.Orders);
    }

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      Vendor vendor = new Vendor("name", "description");
      int result = vendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnAllVendors_VendorList()
    {
      Vendor vendor1 = new Vendor("name1", "description1");
      Vendor vendor2 = new Vendor("name2", "description2");
      List<Vendor> expectedList = new List<Vendor> { vendor1, vendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(expectedList, result);
    }

    [TestMethod]
    public void Find_ReturnSpecificVendor_Vendor()
    {
      Vendor vendor1 = new Vendor("name1", "description1");
      Vendor vendor2 = new Vendor("name2", "description2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(vendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddOrderToSpecificVendor_OrderList()
    {
      Order order = new Order("title", "itemType", 2, 5.50, "dueDate");
      List<Order> expectedOrders = new List<Order> { order };
      Vendor vendor = new Vendor("name", "description");
      vendor.AddOrder(order);
      List<Order> result = vendor.Orders;
      CollectionAssert.AreEqual(expectedOrders, result);
    }

    [TestMethod]
    public void RemoveOrder_RemoveOrderFromSpecificVendor_OrderList()
    {
      Order order1 = new Order("title", "itemType", 2, 5.50, "dueDate");
      Order order2 = new Order("title2", "itemType2", 3, 3.50, "dueDate2");
      Vendor vendor = new Vendor("name", "description");
      vendor.AddOrder(order1);
      vendor.AddOrder(order2);
      vendor.RemoveOrder(order2);
      List<Order> expectedOrders = new List<Order> { order1 };
      List<Order> result = vendor.Orders;
      CollectionAssert.AreEqual(expectedOrders, result);
    }
  }
}