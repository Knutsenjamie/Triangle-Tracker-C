using System;

namespace Triangle 
{
  public class CheckTriangle
  {
    public string CheckTriangleMethod (int side1, int side2, int side3)
    {
      if (side1 == side2 || side2 == side3 || side3 == side1)
      {
      Console.WriteLine("YAY you made an isoceles triangle");
      }
      else if (side1 != side2 && side2 != side3 && side3 != side1)
      {
      Console.WriteLine("YAY you made an scalene triangle");
      }
      else if (side1 == side2 && side2 == side3 && side3 == side1)
      {
      Console.WriteLine("YAY you made an equilateral triangle");
      }
    }
  }
}
