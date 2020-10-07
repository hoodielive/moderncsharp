using System;
using System.Diagnostics;

public class TupleExample 
{
	public (string, int, bool) GetGuitarType()
	{
		return ("Near Death Experience @", 15, false);
	}

	public (string firstName, string lastName) OpenPositionApp()
	{
		return ("True", "blood");
	}

	public void PlayInstrument((string, int) instrumentToPlay)
	{
		Debug.WriteLine($"I am playing {instrumentToPlay.Item1} with {instrumentToPlay.Item2} strings");
	}
}
