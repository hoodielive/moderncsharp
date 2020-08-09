using System;
using System.Collections.Generic;


public class ClassOnEnums
{
    const string CONSTANT_NAME = "company";
    readonly string ConstantName = "company";

    enum Days { Mon, Tue, Wed, Thurs, Fri, Sat, Sun }

    Days today = Days.Thurs;

    public void EnumArson()
    {
        if (this.today == Days.Thurs)
            Console.WriteLine("Today is Thursday.");
    }

    public void Enuma()
    {
        switch (today)
        {
            case Days.Mon:
                Console.WriteLine("It's Monday!");
                break;
            case Days.Tue:
                Console.WriteLine("It's Tuesday!");
                break;
            case Days.Wed:
                Console.WriteLine("It's Wednesday!");
                break;
            case Days.Thurs:
                Console.WriteLine("It's Thursday!");
                break;
            case Days.Fri:
                Console.WriteLine("It's Friday!");
                break;
            case Days.Sat:
                Console.WriteLine("It's Saturday!");
                break;
            case Days.Sun:
                Console.WriteLine("It's Sunday!");
                break;
            default:
                Console.WriteLine("You are not using English or something.");
                break;
        }
    }
}