using System; 

namespace RunTypes
{
	public class Person 
	{
		public string name;
		public int age;
		public void Display()
		{
			Console.WriteLine("Her name is {0} and her age is {1}", name, age);
		}
	}
}
