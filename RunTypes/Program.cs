using System; 

namespace RunTypes 
{
	class Withering
	{
		
		public static void Main(string[] args)
		{
			Vector vector = new Vector();
			vector.x = 10;
			vector.y = 12;

			Console.WriteLine("Vector X is in the size of {0}", vector.x);
			Console.WriteLine("Vector Y is in the size of {0}", vector.y);
			Console.WriteLine("Does Vector Z contain a value of 0 ?  {0}", vector.z);

			Person person = new Person();
			person.name = "Shaharazad";
			person.age = 20;
			person.Display();

			Propria persona = new Propria(); 
			Console.WriteLine("The Propria name is {0} and the age is {1}", persona.name, persona.age);
		}
	}

	struct Vector 
	{
		public int x; 
		public int y;
		public int z;
	}
}
