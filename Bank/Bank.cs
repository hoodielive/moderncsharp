class Bank
{
	private Dictionary<int, Account> accounts; 
	public Dictionary<int, Account> Accounts
	{
			get { return accounts; }
	}

	public Bank()
	{
			accounts = new Dictionary<int, Account>(); 
	}
	
	public void AddAccount(int number, Account account)
	{
		try 
		{
			accounts.Add(number, account);
		}
		catch (Exception)
		{
		}
	}

	public Account GetAccount(int number)
	{
		Account a;
		accounts.TryGetValue(number, out a);
		return a; 
	}
}
