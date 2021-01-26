using System;

namespace OdInterfacing
{
    public class SoftwareDeveloper : Developer, NewInterface

    {
        public SoftwareDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {

        }

        public void Republic()
        {
            Console.WriteLine("This ensure(s) that the following is not forgotten.");
        }
    }
}