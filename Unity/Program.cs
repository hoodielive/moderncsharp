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
        }
    }
}
