using System;

namespace GradeBook.Playground
{
    class Program
    {
        static public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
        }

        static Book GetBook(string name)
        {
            return new Book(name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TwoVarsCanReferenceSameObject();
        }
    }
}
