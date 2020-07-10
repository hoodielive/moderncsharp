using System;

namespace sandy
{
	class wall
	{
		public static void main()
		{
			pickles prelay = new pickles();

			prelay.YallBetterRecognize();

		}
	}

	class Pickles
	{

		private int _x; 

		private int _y; 

		string? name; 

		protected internal string Z;


		public Pickles() {}

		public Pickles(int x, int y)
		{
			this.x = x; 
			this.y = y;
		}

		// public abstract void returnPickles();

		public string BodyIsPureGold() 
		{

		}

		public string YallBetterRecognize()
		{
			string[] words = { "apple", "strawberry", "grape", "peach", "banana" };

			var wordQuery = from word in words
											where word[0] == 'g'
											select word;

			foreach (string s in wordQuery)
			{
				Console.WriteLine(s);
			}

		}
	}
}

