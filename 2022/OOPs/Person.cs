class Person 
{
  private string _FirstName = null!;
  private string _LastName = null!; 
  private string _MiddleName = null!;
  public string location = null!;
  private int age;
  

  public string firstName { 
    get
    {
      return _FirstName; 
    }

    set
    {
      firstName = value;
    }
  }

  public string lastName { 
    get
    {
      return _LastName; 
    }

    set
    {
      lastName = value;
    }
  }

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

}
