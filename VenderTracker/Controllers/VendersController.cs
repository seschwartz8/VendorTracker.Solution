using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VenderTracker.Models;

namespace VenderTracker.Controllers
{
  public class VendersController : Controller
  {
    [HttpGet("/venders")]
    public ActionResult Index()
    {
      // Display list of venders
      List<Vender> venders = Vender.GetAll();
      return View(venders);
    }

    [HttpGet("/venders/new")]
    public ActionResult New()
    {
      // Offer form to create new vender
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string name, string description)
    {
      // Create new Vender object
      Vender newVender = new Vender(name, description);
      return RedirectToAction("Index", "/");
    }

    [HttpGet("/venders/deleteAll")]
    public ActionResult DeleteAll()
    {
      // Clear all venders
      Vender.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/venders/{id}")]
    public ActionResult Show(int id)
    {
      // Display one vender's description and all their orders
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vender specificVender = Vender.Find(id);
      List<Order> orderList = specificVender.Orders;
      model.Add("vender", specificVender);
      model.Add("orders", orderList);
      return View(model);
    }

    [HttpPost("/venders/{venderId}/orders")]
    public ActionResult Create(int venderId, string title, string type, int amount, string priceString, string date)
    {
      // Create new Order within a given Vender, not creating a new Vender:
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vender specificVender = Vender.Find(venderId);
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
      specificVender.AddOrder(newOrder);
      List<Order> venderOrders = specificVender.Orders;
      model.Add("orders", venderOrders);
      model.Add("vender", specificVender);
      return View("Show", model);
    }

    [HttpGet("/venders/{venderId}/orders/{orderId}/delete")]
    public ActionResult DeleteOrder(int venderId, int orderId)
    {
      // Delete specific order
      Order specificOrder = Order.Find(orderId);
      Vender specificVender = Vender.Find(venderId);
      specificVender.RemoveOrder(specificOrder);
      return RedirectToAction("Index");
    }
  }
}