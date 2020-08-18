using System;

public class JujitsuRanks
{
    // accessor -> type -> name 
    private string _name;
    private string _age;

    private string _black;
    private string _brown;
    private string _purple;

    private string _rank { get; set; }

    private string _gender;

    public enum Rank { _purple, _black, _brown }


    #region 
    public string Name
    {
        get
        {
            return _name; 
        }

        set {
            this._name = value;
        }
    }

    public string Age
    {
        get 
        {
            return _age;
        }
        set
        {
            this._age = value;
        }
    }

    public string Gender
    {
        get
        {
            return _gender;
        }
        set
        {
            this._gender = value;
        }
    }

    public string Black
    {
        get 
        {
            return _black;
        }
        set
        {
            this._black = value;
        }
    }

    public string Brown
    {
        get
        {
            return this._brown;
        }
        set
        {
            this._brown = value;
        }
    }

    public string Purple
    {
        get 
        {
            return _purple;
        }
        set
        {
            this._purple = value;
        }
    }

    #endregion
    // Create Method the will obtain information from User.

    public string GetUserName()
    {
        Console.WriteLine("Hey what is your name?");
        this._name = Console.ReadLine();
        Console.WriteLine($"Hello {Name}"); 
        return this._name;
    }

    public string GetUserAge()
    {
        Console.WriteLine("Hey, what is your age?");
        this._age = Console.ReadLine();
        Console.WriteLine($"Your age is {Age}");
        return this._age;
    }

    public void GetUserRank(Rank myRank)
    {

        Console.WriteLine("What is your rank Color homie? ");
        string rankColor = Console.ReadLine();

        if (rankColor == "black")
        {
            myRank = Rank._black;
        }
        else if (rankColor == "brown")
        {
            myRank = Rank._brown;
        }
        else if (rankColor == "purple")
        {
            myRank = Rank._purple;
        }


        switch(rankColor)
        {
            case Rank._brown:
                Console.WriteLine($"Your rank is {this.Brown}.");
                break;
            case Rank._black:
                Console.WriteLine($"Your rank is {this.Black}");
                break;
            case Rank._purple:
                Console.WriteLine($"Your rank is {this.Purple}");
                break;
            default: 
                Console.WriteLine("I have no idea what you are looking for.");
                break;
        }
    }
}
