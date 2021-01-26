using System;

namespace MountAsWel
{
    class Program
    {
        static void Main(string[] args)
        {
        	Console.WriteLine("Enter your name: "); 
					var name = Console.ReadLine();
					Console.WriteLine("Welcome {0}", name);
        }
    }
}
