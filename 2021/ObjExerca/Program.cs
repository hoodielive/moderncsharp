using System;

namespace ObjExerca
{
    class Program
    {
        static void Main(string[] args)
        {
            TellTime timeResource = new TellTime();
            Console.WriteLine(timeResource.TellTimeCurrently());

            Dater moreSpecifics = new Dater();

            Console.WriteLine(moreSpecifics.Stuff());


        }
    }
}
