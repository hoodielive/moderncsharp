using System;

namespace NodeAccess
{
    public class Node 
    {
        public static void Main(string[] args)
        {
           Base myContingency = new Base();
           Base returnTheStatic = new Base();
           Console.WriteLine(myContingency.number);
        }
    }
}