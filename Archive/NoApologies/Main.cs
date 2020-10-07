using System;

namespace NoApologies
{
    class Program
    {
        static void Main(string[] args)
        {
					int a = 100000;
					int b = 100000;
					int c = checked (a * b);

					checked
					{
						c = a * b; 
					}

					int x = int.MaxValue + 1;
					int y = unchecked (int.MaxValue + 1);
        }
    }
}
