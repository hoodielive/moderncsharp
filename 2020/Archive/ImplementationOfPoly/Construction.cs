using System; 

public class Construction
{
    private string bodyoftext;
    private string title;
    public Construction()
    {
        bodyoftext = "";
        title = "";
    }

    public Construction(string bodyOfText, string title) : this()
    {
        this.bodyoftext = bodyOfText;
        this.title = title;

    }

    public void SetMessage(string name)
    {
        name = bodyoftext;
        Console.WriteLine($"Hello from {name}");
    }
}

public class PostIt : Construction
{
    public PostIt() {}
    private static void SetMessage(Construction construct)
    {
        construct.SetMessage("Sweet Poly.");
        Console.WriteLine(construct);
    }
}


public class PressIt : Construction
{
    public PressIt() : base("Body of Text", "title")
    {

    }
}