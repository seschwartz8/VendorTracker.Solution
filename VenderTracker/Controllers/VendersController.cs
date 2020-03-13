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

    // [HttpGet("/objects/{id}")]
    // public ActionResult Show(int id)
    // {
    //   //Displays one ClassName's specific details
    //   ClassName foundClassName = ClassName.Find(id);
    //   return View(foundClassName);
    // }
  }
}