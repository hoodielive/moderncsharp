public class Person
{
  public string FirstName = null!;
  public string LastName = null!;
  public string MiddleName = null!;

  public void Introduce()
  {
    Console.WriteLine(($"My name is {FirstName} {MiddleName} {LastName}"));
  }
}
