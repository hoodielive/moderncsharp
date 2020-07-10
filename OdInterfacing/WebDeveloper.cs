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
    }
}