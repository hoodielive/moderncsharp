using System; 

public class FigureSomethingOut
{
	private string _name { get; set; }
	private string _power { get; set; }

	public FigureSomethingOut() {}

	public string FigureItOutYo(string name) 
	{
		_name = name; 
		return _name;
	}

}
