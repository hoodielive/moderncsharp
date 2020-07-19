using System; 

namespace CheckIt
{
	public class Bishop 
	{
		public static void Main(string[] args)
		{
		}
		public string GetName(int ID)	
		{
			if (ID < name.Length)
				return names[ID];
			else
				return String.Empty;
		}
		private string[] names = { "Osa Meji", "Oyeku Meji", "Ofun Meji" };
	}
}
