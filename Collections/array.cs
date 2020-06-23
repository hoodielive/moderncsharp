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

		foreach (string day in daysOfWeek)
		{
			Console.WriteLine(day);
		}
	}
}



