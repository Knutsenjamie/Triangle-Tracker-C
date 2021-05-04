using System;

namespace Triangle
{
  public class Program
    {
      static void Main()
      {
        Console.WriteLine("Please enter in a number for side 1");
        string side1 = Console.ReadLine();
        try
        {
          int intSide1 = int.Parse(side1);
        }
        catch (FormatException e)
        {
          Console.WriteLine("Error: ", e.Message);
          Main();  
        }
        Console.WriteLine("Please enter in a number for side 2");
        string side2 = Console.ReadLine();
        try
        {
          int intSide2 = int.Parse(side2);
        }
        catch (FormatException e)
        {
          Console.WriteLine("Error: ", e.Message);
          Main();  
        }
        Console.WriteLine("Please enter in a number for side 3");
        string side3 = Console.ReadLine();
        try
        {
          int intSide3 = int.Parse(side3);
        }
        catch (FormatException e)
        {
          Console.WriteLine("Error: ", e.Message);
          Main();  
        }
        // if (EquilateralTriangle.IsEquilateralTriangle(int intside1, int intside2, int intside3));
        // {

        // Console.WriteLine("")
        // }
    }
  }
}

