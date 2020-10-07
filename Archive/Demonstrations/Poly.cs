using System; 

class OverloadingShiii
{
	public int Add(int x, int y)
	{
		return x + y
	}

	public double Add(double x, double y)
	{
		return x + y;
	}

	public string Add(string s1, string s2)
	{
		return string.Concat(s1, s2);
	}
}
