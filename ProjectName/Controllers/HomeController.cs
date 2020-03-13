using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    // The line above is a route decorator -- it overrides needing to go to home/index, instead just /index
    public ActionResult Index() { return View(); }
  }
}