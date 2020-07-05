using System;

namespace NodeAccess
{
    public class Base
    {
        public static int weiner { get; set; }
        protected internal int number = 0;

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