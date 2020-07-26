using System;

namespace OdInterfacing
{
    public abstract class Developer 
    {
        private string _mainDevLanguage; 
        public string firstExtraDevLanguage;
        public string secondExtraDevLanguage;

        protected Developer(string mainDevLanguage)
        {
            _mainDevLanguage = mainDevLanguage;
        }


        public virtual void Code()
        {
            Console.WriteLine($"I am coding using my main dev language {_mainDevLanguage}");
        }



        public virtual void Code(string extraDevLanguage)
        {
            Console.WriteLine($"I am coding using my main dev language {_mainDevLanguage}. Additionally, I am using as extra dev language.");
        }

        public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage)
        {
            Console.WriteLine($"I am coding using my main dev language {_mainDevLanguage}. Additionally, I am using {firstExtraDevLanguage} and {secondExtraDevLanguage} as an extra language.");

        }

    }
}