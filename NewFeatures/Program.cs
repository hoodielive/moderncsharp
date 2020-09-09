using System;

namespace NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create object.

			TupleExample te = new TupleExample(); 

			// Implicit Variable. 

			var guitarResult = te.GetGuitarType();

			Console.WriteLine(guitarResult.Item1);
			Console.WriteLine(guitarResult.Item2);
            Console.WriteLine(guitarResult.Item3);

            var newPosition = te.OpenPositionApp();
            (string Firsty, string Lasty) newTuple = te.OpenPositionApp();
            Console.WriteLine(newPosition.firstName, newPosition.lastName);
            Console.WriteLine(newTuple.Firsty, newTuple.Lasty);
        }
    }
}
