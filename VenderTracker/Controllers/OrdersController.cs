using Microsoft.AspNetCore.Mvc;
using VenderTracker.Models;

namespace VenderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/venders/{venderId}/orders/new")]
    public ActionResult New(int venderId)
    {
      // Offers form to create new Order for a specific Vender
      Vender vender = Vender.Find(venderId);
      return View(vender);
    }

    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }

    // [HttpGet("/categories/{categoryId}/items/{itemId}")]
    // public ActionResult Show(int categoryId, int itemId)
    // {
    //   Item item = Item.Find(itemId);
    //   Category category = Category.Find(categoryId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("item", item);
    //   model.Add("category", category);
    //   return View(model);
    // }
  }
}