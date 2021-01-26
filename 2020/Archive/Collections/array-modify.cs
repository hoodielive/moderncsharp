using System;
using System.Collections;
using System.Collections.Generic;

class ModifyArrays
{
	static void Main(string[] args)
	{
		string[] daysOfWeek = {
			"Sunday",
			"Monday",
			"Tuesday",
			"Wenesday",
			"Thursday",
			"Friday",
			"Saturday",
		};

		// Correct name.

		Console.WriteLine("Before:")
		foreach (string day in daysOfWeek)
			Console.WriteLine(day);

		daysOfWeek[2] = "Wednesday";

		Console.WriteLine("After:")
		foreach (string day in daysOfWeek)
			Console.WriteLine(day);
	}
}
