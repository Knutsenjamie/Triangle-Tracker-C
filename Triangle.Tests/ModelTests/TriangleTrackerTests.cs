using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class IsocelesTriangleTests
  {
    [TestMethod]
    public void IsIsoscelesTriangle_TwoSidesAreEqual_True()
    {
      IsocelesTriangle testIsocelesTriangle = new IsocelesTriangle();
      Assert.AreEqual(true, testIsocelesTriangle.IsIsocelesTriangle(2, 2, 1));
    }
  }
  [TestClass]
  public class IsEquilateralTriangleTests
  {
    [TestMethod]
    public void IsEquilateralTriangle_AllSidesAreEqual_True()
    {
      EquilateralTriangle testEquilateralTriangle = new EquilateralTriangle();
      Assert.AreEqual(true, testEquilateralTriangle.IsEquilateralTriangle(2, 2, 2));
    }
  }
  [TestClass]
  public class ScaleneTriangleTests
  {
    [TestMethod]
    public void IsScaleneTriangle_AllSidesAreDifferent_True()
    {
      ScaleneTriangle testScaleneTriangle = new ScaleneTriangle();
      Assert.AreEqual(true, testScaleneTriangle.IsScaleneTriangle(5, 4, 6));
    }
  } 
}

// {
  // any necessary logic to prep for test; instantiating new classes, etc.
  // Assert.AreEqual(EXPECTED RESULT ie .true , CODE TO TEST// our method?// );
// }

// Scalene All sides are different
// Equilateral All sides are equal