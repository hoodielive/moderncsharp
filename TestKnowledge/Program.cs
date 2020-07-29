using System;
namespace TestKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
					 Orisha orisha = new Orisha();
					 var revealing = orisha.OrishaRevealed("Yemoja", "Ogun");
					 Console.WriteLine($"The first Orisha is {revealing}");

					 Yemoja yemoja = new Yemoja();
					 yemoja.Power(); 
		
					 Ogun ogun = new Ogun();
					 ogun.Power();
        }
    }
}
