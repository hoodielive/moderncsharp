using System; 

public class Developer 
{
	private string _mainDevLanguage; 
	
	public Developer(string mainDevLanguage)
	{
		this._mainDevLanguage = mainDevLanguage;
	}

	public virtual void Code(string firstExtraDevLanguage=null, string secondExtraDevLanguage=null)
	{
		if (firstExtraDevLanguage == null && secondExtraDevLanguage == null)
		{
			Console.WriteLine($"I am coding using my main dev language {_mainDevLanguage}");
		}
		else if (firstExtraDevLanguage != null && secondExtraDevLanguage != null)
		{
			Console.WriteLine($"I am coding using my main language + {_mainDevLanguage} and {firstExtraDevLanguage}"); 
		}
		else if (firstExtraDevLanguage != null)
		{
			Console.WriteLine($"I am coding using {firstExtraDevLanguage}");
		}
		else 
		{
			Console.WriteLine("eff.. off.. ");
		}
	}
}
