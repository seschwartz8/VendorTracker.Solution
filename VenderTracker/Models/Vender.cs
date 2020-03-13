using System;

namespace VenderTracker.Models
{
  public class Vender
  {
    public string Name { get; set; }

    public Vender(string name)
    {
      Name = name;
    }

    public bool MethodName()
    {
      return true;
    }
  }
}