using System;

class Program
{
	static void Main(string[] args)
	{
		string filePath = @"Pop by Largest Final.csv";
		CsvReader reader = new CsvReader(filePath);

		Country[] countries = reader.ReadFirstNCountries(10);

		foreach (Country country in countries)
		{
			Console.WriteLine($"{country.Population}: {country.Name}");
		}
	}
}
