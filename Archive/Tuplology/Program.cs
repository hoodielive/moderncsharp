using System;

namespace Tuplology
{
    class Program
    {
        static void Main(string[] args)
        {
						var t1 = new Tuple<double, int>(4.5, 3);
						Console.WriteLine($"Tuple with elements { t1.Item1 } and { t1.Item2 }.");
						
						var (Sum, Count) = new Tuple<double,int>(4.5, 3);
						Console.WriteLine($"Sum is { Count } and { Sum }.");
        }
    }
}
