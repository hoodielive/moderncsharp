using System;

namespace StaticPoly
{
    class Program
    {
        static void Main(string[] args)
        {
           Developer devPraxis = new Developer("Csharp");
					 devPraxis.Code();
					 devPraxis.Code("C#");
					 devPraxis.Code(null, "Javascript");
        }
    }
}
