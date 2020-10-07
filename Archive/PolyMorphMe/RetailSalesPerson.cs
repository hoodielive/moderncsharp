using System;

namespace OdInterfacing
{
    public class RetailSalesPerson : Salesman, SelfDeveloping
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(string.Format("Hi my name is {0}. Pleasure to meet you!", this.FullName));
        }

        public void Develop()
        {
            Console.WriteLine("I develop myself by watching retail sales training videos.");
        }

        public void Clarify()
        {
            Console.WriteLine("Some people are born - others are made.");
        }

        public void Model()
        {
            Console.WriteLine("Dont drive like an idiot, please...");
        }
    }
}
