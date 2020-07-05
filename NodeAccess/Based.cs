using System;

namespace NodeAccess
{
    public class Base
    {
        public static int weiner { get; set; }
        public int number { get; set; }

        public Base()
        {

        }

        public Base(int x)
        {
            weiner = x;
        }

        static Base()
        {
            weiner = 9;
            Console.WriteLine(weiner);
        }
    }
}