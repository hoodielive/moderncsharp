using System;

namespace VTank
{
    public class Test
    {
        public static void Main()
        {
            Test2 test2 = new Test2();
            Console.WriteLine(test2.StartInt(12));
            Console.WriteLine(test2.StartFloat(3.3f));
        }
    }
}
