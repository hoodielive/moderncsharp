using System;

namespace RecursiveLove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(35.9));
						RecursiveFactorial recursiveLove = new RecursiveFactorial();

						recursiveLove = recursiveLove.MainMence();
						Console.WriteLine(recursiveLove);
        }

				static double Fib(double n)
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
