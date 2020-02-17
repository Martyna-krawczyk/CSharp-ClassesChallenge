using System;
using System.Collections.Generic;
using Library;

namespace ClassesChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            //Shelf.AddBook();
            //Shelf.AddBook();
            //Console.WriteLine(Shelf.numberOfBooks);

            //1st Method
            Book LeanIn1 = new Book(
                "Lean In1",
               "Sheryl Sandberg1",
               300
                );


            //2nd Method
            Book LeanIn2 = new Book(
               "Lean In2",
               "Sheryl Sandberg2",
               300,
               new List<string>() { "Alex", "Jill", "Peter" }
               ) ;

            LeanIn1.AddCharacter("Regina");

            //Console.WriteLine(LeanIn1.pages);

            Shelf.AddBook(LeanIn1);
            Shelf.ListBooks();
        }
    }


}
