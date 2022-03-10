  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using System.Collections.Generic;
  using PierresBakery.Models;
  using System;

  namespace PierresBakery.Tests
  {

    [TestClass]
    public class OrderTests : IDisposable
    {

      public void Dispose()
      {
        Order.ClearAll();
      }

      [TestMethod]
      public void OrderConstructor_CreatesInstanceOfOrder_Order()
      {
        Order newOrder = new Order("test", "test", 0);
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }

      [TestMethod]
      public void GetDescription_ReturnsDescription_String()
      {
          
        string description = "buy a dog.";

          
        Order newOrder = new Order("name",description, 0);
        string result = newOrder.Description;

          
        Assert.AreEqual(description, result);
      }

      public void GetName_ReturnsName_String()
      {
          
        string name = "Dog";

          
        Order newOrder = new Order(name,"description", 0);
        string result = newOrder.Name;

          
        Assert.AreEqual(name, result);
      }

      public void GetPrice_ReturnsPrice_Int()
      {
          
        int price = 500;

          
        Order newOrder = new Order("name","description", price);
        int result = newOrder.PurchasePrice;

          
        Assert.AreEqual(price, result);
      }

      [TestMethod]
      public void SetDescription_SetDescription_String()
      {
          
        string description = "Buy a dog.";
        Order newOrder = new Order("name",description, 0);

          
        string updatedDescription = "Buy a cat";
        newOrder.Description = updatedDescription;
        string result = newOrder.Description;

          
        Assert.AreEqual(updatedDescription, result);
      }

      [TestMethod]
      public void GetAll_ReturnsEmptyList_OrderList()
      {
           
        List<Order> newList = new List<Order> { };

           
        List<Order> result = Order.GetAll();

           
        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void GetAll_ReturnsOrders_OrderList()
      {
          
        string description01 = "Buy a dog";
        string description02 = "Buy some dishes";
        Order newOrder1 = new Order("name",description01, 0);
        Order newOrder2 = new Order("name",description02, 0);
        List<Order> newList = new List<Order> { newOrder1, newOrder2 };

          
        List<Order> result = Order.GetAll();

          
        CollectionAssert.AreEqual(newList, result);
      }


      [TestMethod]
      public void Find_ReturnsCorrectOrderFromDatabase_Order()
      {
          
        Order firstOrder = new Order("grass", "Buy lawn grass", 0);
        Order secondOrder = new Order("mower","Buy lawn mower", 0);

          
        Order foundOrder = Order.Find(secondOrder.Id);
          
        Assert.AreEqual(secondOrder, foundOrder);
      }
    }
  }