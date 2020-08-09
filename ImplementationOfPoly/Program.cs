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
            godofWar.Ibi();

            Stack<string> stack = new Stack<string>(10);

            string myString;
            int myInteger;

            stack.Push("aeon");
            stack.Push("aethyr");

            myString = stack.Pop();

            Stack<int> stack2 = new Stack<int>(10);

            Stack<double> stack3 = new Stack<double>(10);

            // Swap Generic.
            GenericMethodExploration positSwap = new GenericMethodExploration();

            positSwap.RevealSwap();

            ClassOnArrays arrayClarity = new ClassOnArrays();
            arrayClarity.Aris();

            ClassOnEnums enumsClarity = new ClassOnEnums();
            enumsClarity.EnumArson(); 
        }
    }
}