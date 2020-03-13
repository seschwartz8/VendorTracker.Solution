using Microsoft.VisualStudio.TestTools.UnitTesting;
using VenderTracker.Models;

namespace VenderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      Order order = new Order();
      Assert.AreEqual(typeof(Order), order.GetType());
    }

  }
}