using System;

public ProblemSherrif
{
	public class SettleIt
	{
		public static void Main()
		{
			Enemy enemy = new Enemy("Wizard");
			Console.WriteLine(enemy);
		}
	}

	public class Player 
	{
		public Player( string moods )
		{
			string mood = moods;
		}
	}

	public class Enemy : base(moods) 
	{
			string anotherMood = moods;	
	}
}
