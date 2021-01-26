using System;

namespace Generica
{
    class Program
    {
        private static Dumpster _dumpster;
        static void Main(string[] args)
        {
            _dumpster = new Dumpster(); 
            _dumpster.Dispose(new Bottle(), new Bottle(), new Food(), new Trash());
            _dumpster.Process();
        }
    }
}
