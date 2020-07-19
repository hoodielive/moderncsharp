using System;
using System.Collections;
using System.Collections.Generic; 

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
					string[] comedians = {
						"Leo Gallagher",
						"Rodney Dangerfield",
						"George Carlin",
						"Lenny Bruce",
						"Eddie Murphy",
						"Louie Anderson"
					};
	
					// TODO: Create the List.
					List<string> strList = new List<string>(10);

					// TODO: Add some elements to the list from an existing array.
					strList.Add("Larry Fey");
					strList.Add("Larry Fey");

					// TODO: Examine the Count and Capacity.
					Console.WriteLine("Count and Capacity: {0}, {1}", strList.Count, strList.Capacity);
        }
    }
}
