using System;

public class Customer
{
	private string name; 
	public string Name 
	{ 
		get 
		{ 
			return Name; 
		} 
		set 
		{
			this.name = Name;
	  }
  }

	public string ReturnTheProperties(string name)
	{
		this.Name = name;
		return name; 
	}

	public void Nuller()
	{
			// 	private object syncHandle = new Object();
			// lock (syncHandle); 
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException ( "Name cannot be blank", nameof(Name));
			}
	}
}
