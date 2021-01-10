﻿using System;

namespace CPro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool complete = true;
            bool started = false;

            if (complete)
            {
                int x = 5;
                Console.WriteLine(x);
            }
            else if (started)
            {
                int x = 3;
                Console.WriteLine(x);
            }

            StringBuilder sb = new StringBuilder("This is a new string");
            sb.Replace(" ", _);
            Console.WriteLine(sb);
            PrintHi();
            SNullColecse();
            CalculateSizeOf();
            GetObjectType();
            HowDoesThatWork();
        }

        static void PrintHi()
        {
           Console.WriteLine("hi");
        }

        static void SNullColecse()
        {
            object obj1 = null;
            object obj2 = obj1 ?? new object();
            Console.WriteLine(obj2);
        }

        static void CalculateSizeOf()
        {
            Console.WriteLine(sizeof(int));
        }

        static void GetObjectType()
        {
            Console.WriteLine(typeof(int));
        }

        static void HowDoesThatWork()
        {
            // Operator Overloading.
            Type sType = typeof(String);
            System.Console.WriteLine(sType.FullName);
        }
    }
}
