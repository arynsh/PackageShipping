using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Package.Models;

namespace Package.Controllers
{
  public class HomeController : Controller
  {

    // [Route("/")]
    // public ActionResult Index()
    // {
    //   // Item starterItem = new Item("Add New Package");
    //   // return View(starterItem);
    // }

    [Route("/")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/items")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Item myItem = new Item(length, width, height, weight);
      // List<Item> _instances = new List<Item> {};
      return View("Items", Item._instances);
    }

    // [Route("/items/checkout")]
    // public ActionResult Checkout()
    // {
    //   return View("Items", Item._instances);
    // }
  }
}