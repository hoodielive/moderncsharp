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

            PlayClass playClass1 = new PlayClass();

            string ancillary = "Otura ";
            playClass1.SetMessage(ref ancillary);
            Console.WriteLine(ancillary);

            PlayClass playClass2 = new PlayClass();
            
            string genreEx = "Oyeku ";
            playClass2.SetOsana(out genreEx);
            Console.WriteLine(genreEx);

            PlayClass playClass3 = new PlayClass();

            playClass3.SetParams("Hello", "Goodbye", "Talk to you later", "Whats up", "Yo");

            StaticMembers.StaticMemberia();

            Construction constructorStuff = new Construction();
        }
    }
}