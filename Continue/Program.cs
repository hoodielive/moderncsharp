using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Apo", 
                "Osa",
                "Pluto",
                "Keshet"
            };

            Person osameji = new Person();
            osameji.Firstname = names[2];

            osameji.sayHello();

        }
    }
}
