using System;

namespace UnderstandingRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Record1 rla = new("Corey", "Hamburger");
            Record1 rlb = new("Lisa", "Hotdog");
            Record1 rlc = new("Osa", "Meji");

            Class1 cla = new Class1("Storm", "Goddess");

            Console.WriteLine("Record Type:");
            Console.WriteLine($"To String: {rla}");
            Console.WriteLine($"Are the two objects equal: { Equals(rla, rlb)}");
            
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine();

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String: { cla }");
            Console.WriteLine();

            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine($"Are the two objects equal: { Equals(rla, rlc)}");
            
        }
    }
}
