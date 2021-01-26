using System; 

public class Explore
{

    Func<int, int> triple = x => x * 3; 
    var range = Enumerable.Range(1,3);
    var triples = range.Select(triple);

    Console.WriteLine(triples);

}