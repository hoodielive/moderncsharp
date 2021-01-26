using System;

namespace DoesItExist
{
	class ProcessIt
	{
		public void Main(string[] args)
		{
			TimePeriod newTime = new TimePeriod(4, 5);
			Console.WriteLine(newTime.ReturnTime1());
		}
	}

	class TimePeriod
	{
		public TimePeriod(int time1, int time2)
		{
			int timeA = time1;
			int timeB = time2;
		}

		public int ReturnTime1
		{
			get { return timeA; }
			set { timeA = value; }
		}
	}
}
