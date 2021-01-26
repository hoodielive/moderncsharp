using System;

public class RecursiveFactorial
{
	public static void MainMence() 
	{
		Console.Write("n = "); 
		int n = int.Parse(Console.ReadLine());

		double factorial = @Factorial(n);
		Console.WriteLine($"{n}! = {factorial}");
	}

	public static double @Factorial(double n)
	{
		if (n == 0)
		{
			return 1;
		}
		return n * @Factorial(n - 1);
	}
}
