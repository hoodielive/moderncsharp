using System;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            businessLogic.ProcessData(); 

        }
    }
}
