using System;

namespace NullableTypesAndShit
{
	public class TheMain
	{
		public static void Main(string[] args)
		{
			Student student1 = new Student(); 
			student1.VehicleRegistration = null;
			Console.WriteLine(string.Format("Is this really a Nullable Type {0}", student1.VehicleRegistration));
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
