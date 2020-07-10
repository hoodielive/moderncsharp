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
    }
}
