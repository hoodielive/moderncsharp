using System;

namespace NullableTypesAndShit
{
	public class TheMain
	{
		public static void Main(string[] args)
		{
		}
	}
	class Student
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public string? VehicleRegistration { get; set; }
	}
}
