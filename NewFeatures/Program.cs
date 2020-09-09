using System;

namespace NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
			TupleExample te = new TupleExample(); 
			var guitarResult = te.GetGuitarType();

			Debug.WriteLine(guitarResult.Item1);
			Debug.WriteLine(guitarResult.Item2);
            
        }
    }
}
