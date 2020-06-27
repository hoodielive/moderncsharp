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
		}
	}
}
