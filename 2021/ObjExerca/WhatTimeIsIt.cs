using System;

public class TellTime
{
    public string TellTimeCurrently()
    {
        DateTime now;
        now = DateTime.Now;

        // Wait for Enter.
        return $"Now is: {now}";
    }
}
