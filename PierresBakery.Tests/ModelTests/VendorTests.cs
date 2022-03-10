 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using PierresBakery.Models;
 using System.Collections.Generic;
 using System;

 namespace ToDoList.Tests
 {
   [TestClass]
   public class VendorTests : IDisposable
   {

     public void Dispose()
     {
       Vendor.ClearAll();
     }

     [TestMethod]
     public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
     {
       Vendor newVendor = new Vendor("test", "Vendor");
       Assert.AreEqual(typeof(Vendor), newVendor.GetType());
     }

     [TestMethod]
     public void GetName_ReturnsName_String()
     {
       
       string name = "Test Vendor";
       Vendor newVendor = new Vendor(name, "0");

       
       string result = newVendor.Name;

         
        Assert.AreEqual(name, result);
      }

           [TestMethod]
     public void GetDescription_ReturnsDescription_String()
     {
       
       string name = "Test Vendor";
       string description = "test";
       Vendor newVendor = new Vendor(name, description);

       
       string result = newVendor.Name;

         
        Assert.AreEqual(name, result);
      }

      [TestMethod]
      public void GetId_ReturnsVendorId_Int()
      {
         
       string name = "Test Vendor";
      string description = "test";
       Vendor newVendor = new Vendor(name, description);

       
       int result = newVendor.Id;

        
       Assert.AreEqual(1, result);
     }

     [TestMethod]
     public void GetAll_ReturnsAllVendorObjects_VendorList()
     {
       
       string name01 = "Work";
       string description01 = "bleh";
       string name02 = "School";
       string description02 = "blah";
       Vendor newVendor1 = new Vendor(name01, description01);
       Vendor newVendor2 = new Vendor(name02, description02);
       List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

       
       List<Vendor> result = Vendor.GetAll();

        
       CollectionAssert.AreEqual(newList, result);
     }

     [TestMethod]
     public void Find_ReturnsCorrectVendor_Vendor()
     {
       
       string name01 = "Work";
       string description01 = "bleh";
       string name02 = "School";
       string description02 = "blah";
       Vendor newVendor1 = new Vendor(name01, description01);
       Vendor newVendor2 = new Vendor(name02, description02);

       
       Vendor result = Vendor.Find(2);

        
       Assert.AreEqual(newVendor2, result);
     }

     [TestMethod]
     public void AddOrder_AssociatesOrderWithVendor_OrderList()
     {
       
       string orderDescription = "Walk the dog.";
       Order newOrder = new Order("name",orderDescription, 1);
       List<Order> newList = new List<Order> { newOrder };
       string name = "Work";
       string description = "bleh";
       Vendor newVendor = new Vendor(name, description);
       newVendor.AddOrder(newOrder);

       
       List<Order> result = newVendor.Orders;

       
       CollectionAssert.AreEqual(newList, result);
     }
    
   }
 }