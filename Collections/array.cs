using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{

		// Create a List comprising the days of the week.

		string[] daysOfWeek = {
			"Sunday",
			"Monday",
			"Tuesday",
			"Wednesday",
			"Thursday",
			"Friday",
			"Saturday",
		};

		// List all the days of the week in order.

		Console.WriteLine("Which day do you want to display?");
		Console.Write("(Monday = 1, etc.) > ");
		int iDay = int.Parse(Console.ReadLine());

		string chosenDay = daysOfWeek[iDay];
		Console.WriteLine($"That day is {chosenDay}");
	}
}



