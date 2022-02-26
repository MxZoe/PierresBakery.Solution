using Microsoft.AspNetCore.Mvc;
using Todo2.Models;
using System.Collections.Generic;

namespace Todo2.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }


    
  }
}