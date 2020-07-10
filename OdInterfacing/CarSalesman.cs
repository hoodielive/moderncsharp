using System; 

namespace OdInterfacing
{
    public class CarSalesman : Salesman
    {
        public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(string.Format("Howdy, my name is {0}. And I'm your friend to the end!", this.FullName));
        }
    }

}