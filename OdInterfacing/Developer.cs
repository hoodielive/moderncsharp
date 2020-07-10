using System;

namespace OdInterfacing
{
    public abstract class Developer 
    {
        private string _mainDevLanguage; 
        public string firstExtraDevLanguage;
        public string secondExtraDevLanguage;

        public Developer(string mainDevLanguage)
        {
            this._mainDevLanguage = mainDevLanguage;
        }

        public virtual void Code(string firstExtraDevLanguage=null, string secondExtraDevLanguage=null)
        {
            if (firstExtraDevLanguage == null && secondExtraDevLanguage == null)
            {
                Console.WriteLine(string.Format("I am coding using my main dev language {0}.", this._mainDevLanguage));
            }
            else if (firstExtraDevLanguage != null && secondExtraDevLanguage != null)
            {
                Console.WriteLine(string.Format("I am coding using my main dev {0}. Additionally I am using {1} and {2} as an extra language", 
                this._mainDevLanguage, this.firstExtraDevLanguage, this.secondExtraDevLanguage));
            }
        }
    }
}