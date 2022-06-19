namespace Enoch.BL
{
  public class Customer
  {
    public int CustomerId { get; private set; }
    private string _lastName;   
    public string FirstName { get; set; }

    public string LastName
    {
      get
      { 
        return _lastName; 
      }
      set
      { 
        _lastName = value; 
      }
    }
   
    public string FullName
    {
        get { return LastName + "," + FirstName; }
    }
  }
}