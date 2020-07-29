using System;

class Orisha
{
	private string _IYA; 
	private string _BABA; 

	public Orisha() {}
	public Orisha(string iya) 
	{
		_IYA = iya;
	}
	public Orisha(string iya, string baba)
	{
		_IYA = iya; 
		_BABA = baba; 
	}

	public string OrishaRevealed(string female, string male)
	{
		 this._IYA = female;
		 this._BABA = male;
		 return female + " " + male;
	}

	public void OrishaMessage()
	{
		Console.WriteLine("Orisha says, Hi!");
	}
}
