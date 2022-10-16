public class Cartesian
{
  public int X { get; }
  public int Y { get; }
  
  public static class Polar
  {
    public static bool operator is(Cartesian c, out double R, out double Theta)
    {
      R = Math.Sqrt(c.X * c.X + c.Y * c.Y);
      Theta = Math.Atan2(c.Y, c.X);
      return c.X !=0 || c.Y !=0;
    }
  }

}
