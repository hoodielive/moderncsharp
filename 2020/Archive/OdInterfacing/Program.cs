﻿using System;

namespace OdInterfacing
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

            WebDeveloper nick = new WebDeveloper("Csharp");
            nick.Code();
            nick.Develop();
            nick.Model();
            nick.Clarify();

            WebDeveloper vinny = new WebDeveloper("Python");
            vinny.Code();
            vinny.Develop();
            vinny.Model();
            vinny.Clarify();

            SoftwareDeveloper beazly = new SoftwareDeveloper("Rust");
            beazly.Republic();

        }
    }
}
