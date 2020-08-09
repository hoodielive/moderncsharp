using System; 


public class PropertyAccessorExploration
{
    private string bodyOfText; 

    public string title { get; set; }

    public string BodyOfText 
    {
        get
        {
            return bodyOfText; 
        }
        set {
            bodyOfText = value; 
        }
    }

    public int BodyOfTextSize 
    {
        get 
        {
            return bodyOfText.Length;

        }
        set {
            bodyOfText = bodyOfText.Substring(0, value);
        }
    }
    public void Body()
    {

    }
}