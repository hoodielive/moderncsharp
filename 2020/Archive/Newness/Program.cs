using System;

namespace Newness
{
    class Program
    {
        static void Main(string[] args)
        {
					enum Status 
					{
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

							Vector vector = new Vector(); 
							vector.x = 5; 
							vector.y = 10;

							Console.WriteLine("x = {0}", vector.x);
							Console.WriteLine("y = {0}", vector.y);
					}
        }

				struct Vector
				{
					public int x; 
					public int y;
				}
    }
}
