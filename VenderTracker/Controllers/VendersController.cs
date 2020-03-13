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
      //Displays list of venders
      List<Vender> venders = Vender.GetAll();
      return View(venders);
    }

    [HttpGet("/venders/new")]
    public ActionResult New()
    {
      //Offers form to create new vender
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string name, string description)
    {
      //Creates new Vender object
      Vender newVender = new Vender(name, description);
      return RedirectToAction("Index", "/");
    }

    [HttpGet("/venders/deleteAll")]
    public ActionResult DeleteAll()
    {
      //Clears all Venders
      Vender.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/venders/{id}")]
    public ActionResult Show(int id)
    {
      //Displays one vender's description and all their orders
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vender specificVender = Vender.Find(id);
      List<Order> orderList = specificVender.Orders;
      model.Add("vender", specificVender);
      model.Add("orders", orderList);
      return View(model);
    }

    [HttpPost("/venders/{venderId}/orders")]
    public ActionResult Create(int venderId, string title, string type, int amount, double price, string date)
    {
      // Create new Order within a given Vender, not creating a new Vender:
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vender specificVender = Vender.Find(venderId);
      Order newOrder = new Order(title, type, amount, price, date);
      specificVender.AddOrder(newOrder);
      List<Order> venderOrders = specificVender.Orders;
      model.Add("order", venderOrders);
      model.Add("vender", specificVender);
      return View("Show", model);
    }
  }
}