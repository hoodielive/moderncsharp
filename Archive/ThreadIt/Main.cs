using System;

namespace ThreadIt
{
    class Program
    {
				public static void ThreadMethod()
				{
					for (int i = 0; i < 10; i++)
					{
						Console.WriteLine($"ThreadProc: {i}");
						Thread.Sleep(0);
					}
				}
        static void Main(string[] args)
        {
        	Thread t = new Thread(new ThreadStart(ThreadMethod));
					t.Start();

					for (int i = 0; i < 4; i++)
					{
						Console.WriteLine("Main Thread: Do some work.");
						Thread.Sleep(0);
					}
					t.Join();
        }
    }
}
