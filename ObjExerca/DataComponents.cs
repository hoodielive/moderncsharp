using System;

public class Dater
{
    public void Stuff()
    {
        DateTime now = DateTime.Now;

        int day = now.Day;
        int month = now.Month;
        int year = now.Year;
        int hours = now.Hour;
        int minutes = now.Minute;
        int seconds = now.Second;
        DateTime justDateWithoutTime = now.Date;

        Console.WriteLine($"Day: { day }");
        Console.WriteLine($"Month: { month }");
        Console.WriteLine($"Year: { year }");
        Console.WriteLine($"Hours: { hours }");
        Console.WriteLine($"Minutes: { minutes }");
        Console.WriteLine($"Seconds: { seconds }");
        Console.WriteLine($"Date component: { justDateWithoutTime }");
    }
}
