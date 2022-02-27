using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class OrdersController : Controller
  {
    
    [HttpGet("/vendors/{id}/orders/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/{id}/orders/")]
    public ActionResult Create(string orderName, string orderDescription, int purchasePrice)
    {
      Order newOrder = new Order(orderName, orderDescription, purchasePrice);
      return RedirectToAction("Index");
    }

    
  }
}