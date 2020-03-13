using Microsoft.VisualStudio.TestTools.UnitTesting;
using VenderTracker.Models;

namespace VenderTracker.Tests
{
  [TestClass]
  public class VenderTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      Vender vender = new Vender();
      Assert.AreEqual(typeof(Vender), vender.GetType());
    }
  }
}