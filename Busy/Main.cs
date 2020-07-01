using System;

namespace Busy
{
    class Program
    {
        static void Main(string[] args)
        {
						Player player1 = new Player();
						if (returnThePower() == "Wizard")
							Console.WriteLine(player1.returnThePower);
						else
							Console.WriteLine("You are sadly mistaken");
        }
    }
}
