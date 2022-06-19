public class UnitConverter
{
  int ratio;

  public UnitConverter(int unitRadio)
  {
    ratio = unitRadio;
  }
  
  public int Convert(int unit)
  {
    return unit * ratio;
  }
}
