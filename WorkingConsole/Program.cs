using System;
using WorkingLibrary;

namespace WorkingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new LibraryClass("From Console App").Run();

            Console.ReadLine();
        }
    }
}
