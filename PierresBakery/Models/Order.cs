using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Name { get; set; }
    public string Description {get; set;}
    public int PurchasePrice {get; set;}
    public int Id { get; }
    

    public Order(string orderName, string description, int purchasePrice)
    {
      Name = orderName;
      Description = description;
      PurchasePrice = purchasePrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

     public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int orderId)
    {
      return _instances[orderId-1];
    }
  }
}