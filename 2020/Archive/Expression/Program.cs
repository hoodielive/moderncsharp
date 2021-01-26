using System;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4; 
						if ( a is 4 )
							Console.WriteLine("A is 4 {0}", a);
        }

				# FIXME 07-23-2020
				class Employee 
				{
					public Employee(string obj)
					{
						public string Employee; 
						 this.Employee = obj; 
					}
				}


				void myFunction(string obj)
				{
						if ( obj is Employee )
						{
							Employee emp = obj as Employee;
							string name = emp.FirstName; 
						}
				}
    }
		
}
