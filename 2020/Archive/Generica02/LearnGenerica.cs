// Declare the generic class. 

public class GenericaList<T>
{
    public void Add(T input) { }
}

class GenericaTestList
{
    private class ExampleClass {}
    static void Manner()
    {
        // Declare a list of type int
        GenericaList<int> list1 = new GenericaList<int>();
        list1.Add(1);

        // Declare al list of type string. 
        GenericaList<string> list2 = new GenericaList<string>();
        list2.Add("");

        // Declare a list of type Example class. 
        GenericaList<ExampleClass> list3 = new GenericaList<ExampleClass>();
    }
}