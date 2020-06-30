public class Player 
{
	class Rectangle
	{
		public int x = 10, y = 10;
		public int GetArea() 
		{
			return x * y;
		}
	}

	class Square : Rectangle {}
	public string ReturnSomething(string name)
	{
		string result = name;
		return result;
	}
}
