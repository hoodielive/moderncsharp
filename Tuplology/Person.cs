using System; 
using System.Collections; 
using System.Collections.Generic;
						
public class Person
{
	public Person(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName; 
		Age = age;
	}
	public string FirstName { get; }
	public string LastName { get; }
	public string Age { get; }


}
						#region People
						private static readonly List<Person> People = new List<Person>(new[])	
						{
							new Person(id: 1, firstName: "John", lastName: "Doe", age: 26),
							new Person(id: 2, firstName: "Jane", lastName: "Doe", age: 18)
						}
