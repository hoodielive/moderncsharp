using System;
using System.Collections;
using System.Collections.Generic;

class Box
{
	public int Length;
	public int Width;
	public int Height;
	public bool IsOpened;

	public bool Open()
	{
		this.IsOpened = true; 
		Console.WriteLine("It is Open!");
	}

	public bool Close()
	{
		this.IsOpened = false;
		Console.WriteLine("It is closed");
	}
	
	public static void Main(string[] args)
	{
		bool status = true;
		Open();
	}
	
}

