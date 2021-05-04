using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsIsosceles_SideOneEqualToSideTwo_True()
    {
      Triangle testIsocelesTriangle = new Triangle();
      Assert.AreEqual(true, testIsocelesTriangle.IsTriangle(2, 2));
    }
  }
}

{
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
}

// Scalene All sides are different
// Equilateral All sides are equal