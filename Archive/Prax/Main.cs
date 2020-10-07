using System;

namespace Prax
{
	class Objectify
	{
		public static void Main(string[] args)
		{
			Square s = new Square();
			Rectangle r = s; // Up
			Square s2 = (Square)r; // Down
		}
	}
}
