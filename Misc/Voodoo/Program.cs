using System;

namespace Voodoo
{

		enum Status 
		{
			Alive,
			Enabled, 
			Disabled, 
			Dead
		}
    class Program
    {
			static void Main(string[] args)
			{

				Status player = Status.Disabled; 

				switch(player)
				{
					case Status.Alive:
						Console.WriteLine("This thing is Alive.");
						break;
					case Status.Enabled:
						Console.WriteLine("This thing is Enabled.");
						break;
					case Status.Disabled:
						Console.WriteLine("This thing is Disabled.");
						break;
					case Status.Dead:
						Console.WriteLine("This thing is Dead.");
						break;
					default:
						Console.WriteLine("Get out of here!");
					break;
				}
			}
    }
}
