using System;
using Library;

namespace ClassesChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            Shelf.AddBook();
            Shelf.AddBook();
            Console.WriteLine(Shelf.numberOfBooks);
        }
    }

    
}
