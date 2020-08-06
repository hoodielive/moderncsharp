using System;
public class Ogun : Orisha
{
	new public void Qualities() {
		 Console.WriteLine(Name());
	}
	protected override string Name()
	{
		return $"The name of the Orisha is {OrishaName}";
	}
	protected override string Ebo()
	{
		return $"The name of the Orisha Ebo is {OrishaEbo}";
	}
	protected override string Ase()
	{
		return $"The name of the Orisha Ase is {OrishaAse}";
	}
	protected override string Awo()
	{
		return $"The name of the Orisha Awo is {OrishaAwo}";
	}
}
