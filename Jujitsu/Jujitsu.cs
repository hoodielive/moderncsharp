using System;

// public enum Rank { _purple = JujitsuRanks.Purple, _black = JujitsuRanks.Black, _brown = JujitsuRanks.Brown }

public class JujitsuRanks
{
    private string _name;
    private string _age;
    private string _black;
    private string _brown;
    private string _purple;
    private string _gender;

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

    public string GetUserRank()
    {
				string myRank;
        Console.WriteLine("What is your rank Color homie? ");
				myRank = Console.ReadLine();

				string ReturnRankColor()
				{
					 IfBlack(this.Black); 
					 IfBrown(this.Brown); 
					 IfPurple(this.Purple); 
				}

				string IfBlack(string black)
				{
					return $"Your Rank is {this.Black}";
				}
				string IfBrown(string brown)
				{
					return $"Your Rank is {this.Brown}";
				}
				string IfPurple(string purple)
				{
					return $"Your Rank is {this.Purple}";
				}

    }
}

