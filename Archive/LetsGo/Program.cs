using System;

namespace LetsGo
{
    class Program
    {
        static void Main(string[] args)
        {
					// Currency.
           Console.WriteLine("{0 :C}", 12.5);

					// Decimal.
           Console.WriteLine("{0 :D4}", 12);

					 // Fixed-Point.
           Console.WriteLine("{0 :F4}", 12.34354323);

					 // General.
           Console.WriteLine("{0 :G4}", 12.34354323);

					 // Hexadecimal.
           Console.WriteLine("{0 :x}", 180026);
        }
    }
}
