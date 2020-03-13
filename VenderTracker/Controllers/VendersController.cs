using Microsoft.AspNetCore.Mvc;
using VenderTracker.Models;

namespace VenderTracker.Controllers
{
  public class VendersController : Controller
  {
    // [HttpGet("/objects")]
    // public ActionResult Index()
    // {
    //   //Displays list of places
    //   List<ClassName> allObjects = ClassName.GetAll();
    //   return View(allObjects);
    // }

    // [HttpGet("/objects/new")]
    // public ActionResult New()
    // {
    //   //Offers form to create new place
    //   return View();
    // }

    // [HttpPost("/objects")]
    // public ActionResult Create(string description)
    // {
    //   //Creates new ClassName
    //   Place myClassName = new ClassName(description);
    //   return RedirectToAction("Index");
    // }

    // [HttpPost("/objects/delete")]
    // public ActionResult DeleteAll()
    // {
    //   //Clears all ClassNames
    //   ClassName.ClearAll();
    //   return View();
    // }

    // [HttpGet("/objects/{id}")]
    // public ActionResult Show(int id)
    // {
    //   //Displays one ClassName's specific details
    //   ClassName foundClassName = ClassName.Find(id);
    //   return View(foundClassName);
    // }
  }
}