using System;

namespace OdInterfacing
{
    public class WebDeveloper : Developer, SelfDeveloping

    {
        public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {

        }
        public void Develop()
        {
            Console.WriteLine("I develop myself by studing web documentation.");
        }

        public void Clarify()
        {
            Console.WriteLine("I was there from the beginning. Was I not {0}"); 
        }

        public void Model()
        {
            Console.WriteLine("I must be getting sleepy.");
        }
    }
}