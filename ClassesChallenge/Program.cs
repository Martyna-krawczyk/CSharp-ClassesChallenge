using System;

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

    class Shelf
    {
        public static int numberOfBooks = 0;

        public static void AddBook()
        {
            numberOfBooks++;
        }
    }
}
