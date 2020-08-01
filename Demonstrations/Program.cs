using System;

namespace Demonstrations
{
    class Program
    {
        static void Main(string[] args)
        {
					 Console.WriteLine("*** A class demo with 2 objects.");

					 ClassEx1 obA = new ClassEx1();
					 ClassEx1 obB = new ClassEx1();

					 Console.WriteLine("obA.i ={0}", obA.MyInt);
					 Console.WriteLine("obB.i ={0}", obB.MyInt);
        }
    }
}
