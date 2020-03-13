using System;
using System.Collections.Generic;

namespace VenderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Type { get; set; }
    public int Amount { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>() { };

    public Order(string title, string type, int amount, double price, string date)
    {
      Title = title;
      Type = type;
      Amount = amount;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int id)
    {
      return _instances[id - 1];
    }
  }
}