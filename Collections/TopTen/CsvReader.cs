using System;

class CsvReader
{
	private string _csvFilePath;

	public CsvReader(string csvFilePath)
	{
		this._csvFilePath = csvFilePath;
	}

	public Country[] ReadFirstNCountries(int nCountries)
	{
		using (StreamReader sr = new StreamReader(_csvFilePath))
		{
			// Read the header line.

			sr.ReadLine();

			for (int i = 0; i < nCountries; i++)
			{
				string csvLine = sr.ReadLine();
				countries[i] = ReadCountryFromCsvLine(csvLine);
			}
		}
		
		return countries;
	}

	public Country ReadCountryFromCsvLine(string csvLine)
	{
		string[] parts = csvLine.Split(new char[] {','});

		string name = parts[0];
		string code = parts[1];
		string region = parts[2];
		int population = int.Parse(parts[3]);

		return new Country(name, code, region, population);
	}
}
