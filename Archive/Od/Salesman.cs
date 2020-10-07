using System;

namespace Od
{
   public abstract class Salesman
   {
      private string _firstName;
      private string _lastName;

      public string FullName
      {
         get
         {
            return string.Format("{0} {1}", this._firstName, this._lastName);
         }
      }
      public Salesman(string firstName, string lastName)
      {
         this._firstName = firstName;
         this._lastName = lastName; 
      }

      public abstract void Sell();
      public virtual void Seller() 
      {
         Console.WriteLine("Seller will remain private.");
      }
   }

}