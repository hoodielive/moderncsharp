using System; 

public class Person
{

    private string _firstname;

    public string Firstname 
    {
        get 
        {
            return this._firstname;
        }

        set
        {
            this._firstname = value;
        }
    }

    public string sayHello()
    {
        return $"You are a wonderful person {Firstname}";
    }
}