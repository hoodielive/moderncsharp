using System; 
using System.Collections; 
using System.Collections.Generic;

namespace Lists 
{
	class Geeks 
	{
		public static void Main(String[] args)
		{
			List<int> firstList = new List<int>();
			firstList.Add(1);
			firstList.Add(2);
			firstList.Add(3);
			firstList.Add(4);
			firstList.Add(5);
			firstList.Add(6); 
			Console.Write(firstList.Contains(4));

			Point p1 = new Point();
			p1.X = 7;

			Point p2 = p1;

			Console.WriteLine(p1.X);
			Console.WriteLine(p2.X);

			p1.X = 9;

			Console.WriteLine(p1.X);
			Console.WriteLine(p2.X);

			PointClass p3 = new PointClass();
			p3.X = 55;
			p4 = p3;

			Console.WriteLine(p3.XPoint);
			Console.WriteLine(p4.YPoint);
		}
	}
		public struct Point
		{
			public int X;
			public int Y;
		}
		public class PointClass
		{
			int Pointclass()
			{
				PointClass X;
				PointClass Y;
			}
		}
}
