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
      Vender specificVender = Vender.Find(id);
      return View(specificVender);
    }

    //     [HttpPost("/categories/{categoryId}/items")]
    // public ActionResult Create(int categoryId, string itemDescription)
    // {
    //   // Create new Item within a given Category, not new Categories:
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Category foundCategory = Category.Find(categoryId);
    //   Item newItem = new Item(itemDescription);
    //   foundCategory.AddItem(newItem);
    //   List<Item> categoryItems = foundCategory.Items;
    //   model.Add("items", categoryItems);
    //   model.Add("category", foundCategory);
    //   return View("Show", model);
    // }
  }
}