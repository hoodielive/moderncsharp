using System;

namespace ImplementationOfPoly
{
    class Program
    {
        static void Main(string[] args)
        {

            IDeterminant Sankofa;
            Ogun godofWar = new Ogun();
            godofWar.OrishaName = "Ogun";
            Ogun GodofWar = new Ogun();
            Sankofa = GodofWar;
            Sankofa.Ire();
            godofWar.Qualities();
            godofWar.Ire();
            godofWar.Ibi();
        }
    }
}
