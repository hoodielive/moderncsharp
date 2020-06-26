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
			Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter(1)));
		}
	}
}
