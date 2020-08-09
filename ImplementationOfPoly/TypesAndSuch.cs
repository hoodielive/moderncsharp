using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExploreTypes
{
    public void TypeArson()
    {
        float floatNumber = 54.23f;
        int number = 0;

        // Implicit Conversion.

        var implicitVariable = 1; 
        Console.WriteLine(implicitVariable.GetType());

        // Explicit Conversion/Cast.

        floatNumber = number;
        number = (int)floatNumber; 
    }
}