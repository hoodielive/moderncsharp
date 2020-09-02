using System;
using System.Collections;
using System.Collections.Generic;

namespace Generica02
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<float> listerine = new GenericList<float>();
            listerine.AddHead(3.0f);
            Console.WriteLine(listerine);
        }
    }
}
