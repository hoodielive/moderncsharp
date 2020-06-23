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

		// Store the index of the List/Array.
		int iDay = Int32.Parse(Console.ReadLine());

		string chosenDay = daysOfWeek[iDay - 1];
		Console.WriteLine($"That day is {chosenDay}");
	}
}



