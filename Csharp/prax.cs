using System;

class Tutorial 
{
	static void Main()
	{
		Console.WriteLine(ReturnAString("Mr.String"));
		Console.WriteLine(ReturnAInt(14));
		Console.WriteLine(ReturnAChar('c'));
	}

	static string ReturnAString(string astring)
	{
		string result = astring; 
		return result;
	}

	static int ReturnAInteger(int aint)
	{
		int result = aint;
		return result;
	}

	static char ReturnAChar(char letter)
	{
		char result = letter;
		return result;
	}

	static System.Int32 ReturnAInt(System.Int32 aint)
	{
		System.Int32 result = aint;
		return aint;
	}
}
