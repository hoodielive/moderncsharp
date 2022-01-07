using System;

namespace Circe
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Larry", "Blackshear");
            var student = new Student("Larry", "Howdy");

            Console.WriteLine(student == person); 
        }
    }
}
