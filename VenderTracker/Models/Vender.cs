using System;
using System.Collections.Generic;

namespace VenderTracker.Models
{
  public class Vender
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static List<Vender> _instances = new List<Vender>() { };

    public Vender(string name, string description)
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

    public static List<Vender> GetAll()
    {
      return _instances;
    }

    public static Vender Find(int id)
    {
      return _instances[id - 1];
    }

    public static void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}