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
}

public class PostIt : Construction
{
    public PostIt() {}
}


public class PressIt : Construction
{
    public PressIt() : base("Body of Text", "title")
    {

    }
}