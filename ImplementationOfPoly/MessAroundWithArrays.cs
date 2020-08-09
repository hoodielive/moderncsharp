using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfPoly
{
    public class ClassOnArrays
    {
        public void Aris()
        {
            int[] numbers = new int[5] { 4, 5, 6, 7, 8 };
            int[] numbers2 = { 4, 5, 6, 7, 8 };

            // Jagged Arrays.

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 4, 6, 8, 9 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[2] = new int[] { 2, 4, 6, 12, 423, 23, 4123, 23 };

        }

        enum Days { Mon, Tue, Wed, Thurs, Fri, Sat, Sun };

        Days today = Days.Mon;

        if (today == Days.Mon)
        {
            Console.WriteLine("Hey its Monday~!");
        }

        foreach (string s in Enum.GetNames(typeof(Days))) 
        {
            Console.WriteLine(s);
        }
}