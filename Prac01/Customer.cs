using System;

public class Customer
{
	private object syncHandle = new Object();
	private string name; 

	public string Name 
	{ 
		get 
		{ 
			lock (syncHandle); return name; 
		} 
		set {
			if (string.IsNullOrEmpty(value))
				throw new ArgumentException ( "Name cannot be blank", nameof(Name));
	  } 
  }
}
