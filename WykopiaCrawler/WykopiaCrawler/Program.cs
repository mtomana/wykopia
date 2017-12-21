using System;
using System.Diagnostics;

namespace WykopiaCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            //comm 1
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello from .net core");

            if (Debugger.IsAttached)
            {
                Console.Read();
            }
        }
    }
}
