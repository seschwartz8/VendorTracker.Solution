using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      ClassName classObj = new ClassName();
      Assert.AreEqual(typeof(ClassName), classObj.GetType());
    }
  }
}