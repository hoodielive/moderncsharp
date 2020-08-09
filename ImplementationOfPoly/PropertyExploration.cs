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
    public char this[int index]
    {
        get { return bodyOfText[index]; }
        set { 
            char[] bodyTemp = bodyOfText.ToCharArray();
            bodyTemp[index] = value; 
            bodyOfText = new string(bodyTemp);
        }
    }

    public void Body()
    {

    }
}