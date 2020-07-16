using System;

namespace Newness
{
    class Program
    {
        static void Main(string[] args)
        {
					Enum Status {
						Enabled, 
						Disabled,
						Alive,
						Dead
					};

					Status player = Status.Alive; 

					switch(player)
					{
						case Status.Alive:
							Console.WriteLine("Its alive!");
							break;
						case Status.Enabled:
							Console.WriteLine("Its Enabled but not Alive."); 
						case Status.Disabled:
							Console.WriteLine("This item is disabled"); 
						default: 
							Console.WriteLine("Try Again.");
					}
					
        }
    }
}
