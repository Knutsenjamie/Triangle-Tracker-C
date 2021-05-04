namespace Triangle 
{
  public class EquilateralTriangle // should match file name - Well rename file later
  {
    public bool IsEquilateralTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3 && side3 == side1)
      {
        return true;
      }
        else
      {
        return false;
      }
    }
  }
}

