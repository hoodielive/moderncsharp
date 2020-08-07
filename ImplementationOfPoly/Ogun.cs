using System;
public class Ogun : Orisha, IDeterminant
{
	new public void Qualities() 
	{
		Console.WriteLine(Name(11));
		Console.WriteLine(Name(11.32));
	}
	protected override string Name() => $"The name of the Orisha is {OrishaName}";
	protected override int Name(int num) => (num);
	protected override double Name(double num) => (num);
	protected override string Ebo() => $"The name of the Orisha Ebo is {OrishaEbo}";
	protected abstract List<string> Ebo(string first) 
	{
		this.first = new List<string>(); 
	}
	protected override string Ase() => $"The name of the Orisha Ase is {OrishaAse}";
	protected override string Awo() => $"The name of the Orisha Awo is {OrishaAwo}";

	public void Ire()
	{
		Console.Write("Ogun comes with the removal of all obstacles internal and external.\n");
	}
	public void Ibi()
	{
		Console.Write("Ogun comes for the head of those that do evil and that do not live in balance.\n");
	}
	
}