using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      // Display list of vendors
      List<Vendor> vendors = Vendor.GetAll();
      return View(vendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      // Offer form to create new vendor
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string name, string description)
    {
      // Create new Vendor object
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index", "/");
    }

    [HttpGet("/vendors/deleteAll")]
    public ActionResult DeleteAll()
    {
      // Clear all vendors
      Vendor.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      // Display one vendor's description and all their orders
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor specificVendor = Vendor.Find(id);
      List<Order> orderList = specificVendor.Orders;
      model.Add("vendor", specificVendor);
      model.Add("orders", orderList);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string type, int amount, string priceString, string date)
    {
      // Create new Order within a given Vendor, not creating a new Vendor:
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor specificVendor = Vendor.Find(vendorId);
      double price;
      try
      {
        price = Convert.ToDouble(priceString);
      }
      catch
      {
        price = 0.00;
      }
      Order newOrder = new Order(title, type, amount, price, date);
      specificVendor.AddOrder(newOrder);
      List<Order> vendorOrders = specificVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", specificVendor);
      return View("Show", model);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult DeleteOrder(int vendorId, int orderId)
    {
      // Delete specific order
      Order specificOrder = Order.Find(orderId);
      Vendor specificVendor = Vendor.Find(vendorId);
      specificVendor.RemoveOrder(specificOrder);
      return RedirectToAction("Index");
    }
  }
}