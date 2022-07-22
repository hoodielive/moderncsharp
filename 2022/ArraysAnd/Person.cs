public class Person
{
  public string FirstName = null!;
  public string LastName = null!;
  private string _MiddleName = null!;

  public string middleName {
    get 
    {
      return _MiddleName;
    }

    set
    {
      middleName = value;
    }
  }
  

  public void Introduce()
  {
    Console.WriteLine(($"My name is {FirstName} {LastName}"));
    Console.WriteLine(($"The middle name is {middleName}"));
  }
}
