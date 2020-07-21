using System;

namespace NullableTypesAndShit
{
	class Student
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public string VehicleRegistration { get; set; }
	}
}
