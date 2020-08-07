using System; 
using System.Collections; 
using System.Collections.Generic; 

public abstract class Orisha
{
	private string _name; 
	private string _ebo; 
	private string _ase; 
	private string _awo; 

	#region
	public string OrishaName 
	{
		get
		{
			return $"{_name}";
		}

		set {
			this._name = value; 
		}
	}
	public string OrishaEbo
	{
		get
		{
			return $"{_ebo}";
		}
		set {
			this._ebo = value; 
		}
	}

	public string OrishaAse
	{
		get
		{
			return $"{_ase}";
		}
		set {
			this._ase = value; 
		}
	}
	public string OrishaAwo
	{
		get
		{
			return $"{_awo}";
		}

		set {
			this._awo = value; 
		}
	}
	#endregion
	public void Qualities()
	{
		this.Name();
		this.Name();
		this.Ebo();
		this.Ase();
		this.Awo();
	}

	protected abstract string Name(); 
	protected abstract int Name(int howMany); 
	protected abstract double Name(double howMany); 
	protected abstract string Ebo(); 
	// protected abstract List<string> Ebo(string first); 
	protected abstract string Ase(); 
	protected abstract string Awo(); 

}
