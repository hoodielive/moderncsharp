using System;
using System.Diagnostics;

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

			var (BrandType, Music) = te.OpenPositionApp();
			Console.WriteLine(Music);

            TupleExample tryMe = new TupleExample();
            string instrumentType = nameof(InstrumentType.guitar);
            int strings = 12; 

            (string TypeOfInstrument, int NumberOfStrings) instrument = (instrumentType, strings);
            tryMe.PlayInstrument(instrument);
        }
    }
}