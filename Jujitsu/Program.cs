using System;

namespace Jujitsu
{
    class Program
    {
        static void Main(string[] args)
        {
            // This only creates an object.
            JujitsuRanks bjjranks = new JujitsuRanks();

            // This sets the 'Name' property of the object (jjranks) (Setter)

            // Getter
            bjjranks.Age = "36";
            Console.WriteLine(bjjranks.Age);
            bjjranks.Gender = "male";
            Console.WriteLine(bjjranks.Gender);
            bjjranks.Purple = "purple rank";
            Console.WriteLine(bjjranks.Purple);
            bjjranks.Brown = "brown rank";
            Console.WriteLine(bjjranks.Brown);
            bjjranks.Black = ("black rank");
            Console.WriteLine(bjjranks.Black);

            bjjranks.GetUserName();
            bjjranks.GetUserAge();
        }
    }
}
