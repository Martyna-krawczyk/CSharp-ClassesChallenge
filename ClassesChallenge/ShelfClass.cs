using System;
using System.Collections.Generic;
using ClassesChallenge;

namespace Library
{
    public class Shelf
    {
        public static int numberOfBooks = 0;

        private static List<Book> books = new List<Book>();

        public static void AddBook()
        {
            numberOfBooks++;
        }

        /// <summary>
        /// This method adds book to books
        /// </summary>
        /// <param name="book"></param>
        public static void AddBook(Book book)
        {

            books.Add(book); 
        }

        /// <summary>
        /// This method will print book titles from books list
        /// </summary>
        public static void ListBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.title);
            }
        }
    }
}
