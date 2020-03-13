using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class SecondClassesController : Controller
  {
    [HttpGet("/objects")]
    public ActionResult Index()
    {
      //Displays list of places
      List<SecondClass> allObjects = SecondClass.GetAll();
      return View(allObjects);
    }

    [HttpGet("/objects/new")]
    public ActionResult New()
    {
      //Offers form to create new place
      return View();
    }

    [HttpPost("/objects")]
    public ActionResult Create(string description)
    {
      //Creates new SecondClass
      Place mySecondClass = new SecondClass(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/objects/delete")]
    public ActionResult DeleteAll()
    {
      //Clears all SecondClasses
      SecondClass.ClearAll();
      return View();
    }

    [HttpGet("/objects/{id}")]
    public ActionResult Show(int id)
    {
      //Displays one SecondClass's specific details
      SecondClass foundSecondClass = SecondClass.Find(id);
      return View(foundSecondClass);
    }
  }
}