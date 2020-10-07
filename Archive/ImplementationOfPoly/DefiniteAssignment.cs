using System; 
using System.Collections;
using System.Collections.Generic;

public class ExploreDefiniteAssignment
{
    // Class variables have definite assignment.

    int number; 
    public void AssignmentArson()
    {
        int[] numbers = null; 

        numbers = numbers ?? new int[2];

        Console.WriteLine(number);
        Console.WriteLine(numbers);

        int i = 0; 

        bool isOn = i == 0 ? true : false; 
        Console.WriteLine(isOn);
    }
}