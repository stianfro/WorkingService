using System;

namespace WorkingLibrary
{
    public class LibraryClass
    {
        private string _field;
        public LibraryClass(string field)
        {
            _field = field;
        }

        public void Run()
        {
            Console.WriteLine(_field);
        }
    }
}
