using System;

namespace RecursiveLove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(35));
        }

				static long Fib(int n)
				{
					if (n <= 2)
					{
						return 1;
					}
					// Recursion
					return Fib(n - 1) + Fib(n - 2);
				}
    }
}
