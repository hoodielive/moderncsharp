using System;
namespace TestKnowledge
{
    class OrishaProgram
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

					 FigureSomethingOut conventional = new FigureSomethingOut();
					 var instantSuccess = conventional.FigureItOutYo("Onire");
					 Console.WriteLine($"Hello, {instantSuccess}");

					 var ifaAse = new IfaGoodies<string>(); 
					 ifaAse.Field = "A sample of IFA";
					 Console.WriteLine(ifaAse.Field);
        }
    }
}
