using System;
using System.Console;

namespace FSharper
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table: ");

            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = { row * number }");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do 
            {
                Write("Enter a number between 0 and 255: ");
            }
        }
}
