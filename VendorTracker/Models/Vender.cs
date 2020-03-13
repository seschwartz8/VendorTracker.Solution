using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor>() { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>() { };
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int id)
    {
      return _instances[id - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public void RemoveOrder(Order order)
    {
      Orders.Remove(order);
    }
  }
}