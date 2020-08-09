using System;


public class PlayClass
{
    string ancillaryMessage = "Oyeku";
    string genericMessage = "This is a generic message from";

    public void SetMessage(ref string message)
    {
        message += ancillaryMessage;
    }
    public void SetOsana(out string genre)
    {
        genre = ancillaryMessage;
    }
    public void SetParams(params string[] genre)
    {

    }
}