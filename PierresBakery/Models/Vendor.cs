using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name {get;set;}
    public string Description {get;set;}
    public int ID {get;}
    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
    }

    public static Vendor Find(int vendorID)
    {
      return _instances[vendorID - 1];
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void Delete(int vendorID)
    {
      _instances.RemoveAt(vendorID-1);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}