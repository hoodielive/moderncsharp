using System;

namespace Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

						foreach (int element in fibarray)
							Console.WriteLine(element);

						int x = 1;
						do {
							x++;
						} while (x < 10);
						Console.WriteLine(x);

						// Method man.
						string Methos()	
						{
							return "No good logic is available.";
						}

						Console.WriteLine(Methos());

						static void SquareIt(ref int x)
						{
							x *= x; 
							Console.WriteLine($"The value inside the method: {x}");
						}

						int n = 5;
						Console.WriteLine($"The value before calling the method: {n}");
						SquareIt(ref n);
						Console.WriteLine($"The value after calling the method: {n}");

						Console.WriteLine("Press any key to exit.");
						Console.ReadKey();

						static float Add(float x, float y)
						{
							return x + y;
						}

						static float Subtract(float x, float y)
						{
							return x - y;
						}

						static float Divide(float x, float y)
						{
								return x / y;
						}
						static float Multiply(float x, float y)
						{
							return x * y;
						}

						float r1 = Add(2.0f, 2.0f);
						float r2 = Subtract(r1, 2.0f);
						float r3 = Multiply(r2, r1);
						float r4 = Divide(8.0f, 0.0f);

						string r = string.Format($"r1={r1}; r2={r2}; r3={r3}; r4={r4}");
						Console.WriteLine(r);
        }
    }
}
