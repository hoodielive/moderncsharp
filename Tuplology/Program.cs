using System;

namespace Tuplology
{
    class Program
    {
        static void Main(string[] args)
        {
					Tuple<(double, int)> t1 = (4.5, 3); 
						Console.WriteLine($"Tuple with elements { t1.Item1 } and { t1.Item2 }.");
						
						Tuple<(double Sum, int Count)> t2 = (4.5, 3);
						Console.WriteLine($"Sum of { t2.Count } and { t1.Sum }.");
        }
    }
}
