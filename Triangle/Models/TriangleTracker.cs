using System;
using System.Collections.Generic;

namespace Triangle
{
  public class Triangle
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
        Console.WriteLine("Please enter in an integer");
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
        Console.WriteLine("Please enter in an integer");
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
        Console.WriteLine("Please enter in an integer");
        Main();  
      }
    }
  } 
}