using System;

public class RetailSalesPerson : Salesman
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. Pleasure to meet you!", this.FullName));
    }
}
