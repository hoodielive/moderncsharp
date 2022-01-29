// See https://aka.ms/new-console-template for more information

class Orac
{
    public bool isActive = false;
    public int Age = 10;
    static readonly string TempFolder = System.IO.Path.GetTempPath();
    static readonly int legs = 8, eyes = 2;
}

public class Test
{
    public const string Message = "Hello World";
}

public static double Circumference(double radius)
{
    return 2 * System.Math.PI * radius;
}

public static double Circumference(double radius)
{
    return 6.283214859530 * radius;
}
