using System;
using System.Collections.Generic;


public class ClassOnEnums
{
    enum Days { Mon, Tue, Wed, Thurs, Fri, Sat, Sun }

    Days today = Days.Thurs;

    public void EnumArson()
    {
        if (this.today == Days.Thurs)
            Console.WriteLine("Today is Thursday.");
    }
}