using System;

namespace VenderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }

    public Order(string name)
    {
      Name = name;
    }

    public bool MethodName()
    {
      return true;
    }
  }
}