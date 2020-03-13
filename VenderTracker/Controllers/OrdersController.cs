using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VenderTracker.Models;

namespace VenderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/venders/{venderId}/orders/new")]
    public ActionResult New(int venderId)
    {
      // Offers form to create new Order for a specific vender
      Vender vender = Vender.Find(venderId);
      return View(vender);
    }

    [HttpGet("/venders/{venderId}/orders/{orderId}")]
    public ActionResult Show(int venderId, int orderId)
    {
      // Show order information about specific order from specific vender
      Order specificOrder = Order.Find(orderId);
      Vender specificVender = Vender.Find(venderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", specificOrder);
      model.Add("vender", specificVender);
      return View(model);
    }

    [HttpGet("/venders/{venderId}/orders/{orderId}/delete")]
    public ActionResult DeleteOrder(int venderId, int orderId)
    {
      //Delete specific order
      Order specificOrder = Order.Find(orderId);
      Vender specificVender = Vender.Find(venderId);
      specificVender.RemoveOrder(specificOrder);
      return RedirectToAction("Show", "/vender/{venderId}");
    }
  }
}