using System;

namespace CustomS
{
	public class UnitConverter
	{
		// Data member.

		int ratio;

		// Constructor.

		public UnitConverter(int unitRatio)
		{
			ratio = unitRatio;
		}

		// Method.

		public int Convert(int unit)
		{
			return unit * ratio;
		}
	}

	class Test
	{
		static void Main()
		{
			UnitConverter feetToInchesConverter = new UnitConverter(12);
			UnitConverter milesToFeetConverter = new UnitConverter(5280);

			Console.WriteLine(feetToInchesConverter.Convert(30));
			Console.WriteLine(feetToInchesConverter.Convert(100));
			Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));

			Panda p1 = new Panda("Pan Dee");
			Panda p2 = new Panda("Pan Dah");

			Console.WriteLine(p1.Name);
			Console.WriteLine(p2.Name);

			Console.WriteLine(Panda.Population);
		}
	}

	class Panda
	{
		public string Name; // Instance field. 
		public static int Population; // Static Field.


		public Panda(string n) // Constructor.
		{
			Name = n;  // Assign the Instance field.
			Population += 1; // Increment the static population field.
		}
	}
}