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
	class Rectangle
	{
		public int x = 10, y = 10;
		public int GetArea() 
		{
			return x * y;
		}
	}

	class Square : Rectangle {}
}
