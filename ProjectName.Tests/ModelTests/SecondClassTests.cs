using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class SecondClassTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      SecondClass classObj = new SecondClass();
      Assert.AreEqual(typeof(SecondClass), classObj.GetType());
    }

  }
}