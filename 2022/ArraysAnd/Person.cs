public class Person
{
  public string FirstName = null!;
  public string LastName = null!;
<<<<<<< HEAD
  public string MiddleName = null!;

  public void Introduce()
  {
    Console.WriteLine(($"My name is {FirstName} {MiddleName} {LastName}"));
=======
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
>>>>>>> 98b2f3cbf82c4c1ef9e4d443e1642a6f16898209
  }
}
