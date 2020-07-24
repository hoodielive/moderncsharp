using System;

namespace Expression2
{
    class Program
    {
        static void Main(string[] args)
        {
            int price1 = 25;
            int price2 = 3;
						bool lowPrice =  (price1 < price2) ? price1; 

							if (lowPrice)
								Console.WriteLine("It is so!");
        }
    }
}
