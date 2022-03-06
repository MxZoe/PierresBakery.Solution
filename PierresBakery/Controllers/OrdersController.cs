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
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }
    

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor vendor = Vendor.Find(vendorID +1);
      return View(vendor);
    }
    /*
    [HttpPost("/vendors/{id}/orders/")]
    public ActionResult Create(string orderName, string orderDescription, int purchasePrice)
    {
      Order newOrder = new Order(orderName, orderDescription, purchasePrice);
      return RedirectToAction("Index");
    }
    */

    
  }
}