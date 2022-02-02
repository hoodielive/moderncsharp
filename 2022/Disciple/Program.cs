using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity;


using namespace nDisciple
{
    public class Disciple
    {
        public static void Syntax()
        {
            Console.WriteLine("Hello, World");
            Console.WriteLine(
                "Integer: " + 10 +
                "Double: " + 3.14 +
                "Boolean: " + true
            );

            sbyte fooByte = 100;
            byte fooBtye = 100;
            short fooShort = 10000;
            ushort footUshort = 10000;
            int fooInt = 1;
            uint fooUint = 1;
            long fooLong = 100000L;
            ulong fooUlong = 100000L;
            double fooDouble = 123.4;
            float fooFloat = 234.4f;
            decimal fooDecimal = 150.3m;
            bool fooBoolean = true;
            char fooChar = 'A';
            string fooString = "\"escape\"quotes and add \n (new lines) and \t (tabs)";
            Console.WriteLine(fooString);
            char charFromString = fooString[1];
            string fooFs = string.Format("Check Check, {0} {1}, {0}, {1:0:0}", 1, 2);
            DateTime fooDate = DateTime.Now;
        }
    }
}
