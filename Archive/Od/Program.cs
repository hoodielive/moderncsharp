using System;

namespace Od
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman hoodie = new CarSalesman("hoodie", "live");
            Console.WriteLine(hoodie.FullName);
            hoodie.Sell();
            
            RetailSalesPerson sherrifHood = new RetailSalesPerson("Sherrif", "Hood");
            Console.WriteLine(sherrifHood.FullName);
            sherrifHood.Sell();
        }
    }
}
