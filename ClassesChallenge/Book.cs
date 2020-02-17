using System;
using System.Collections.Generic;

namespace ClassesChallenge
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        private List<string> characters = new List<string>();


        /// <summary>
        /// This has three arguments
        /// </summary>
        /// <param name="incomingBookTitle"></param>
        /// <param name="incomingBookAuthor"></param>
        /// <param name="incomingBookPages"></param>
        public Book(string incomingBookTitle, string incomingBookAuthor, int incomingBookPages)
        {
            title = incomingBookTitle;
            author = incomingBookAuthor;
            pages = incomingBookPages;
        }

        /// <summary>
        ///This has all four arguments
        /// </summary>
        /// <param name="incomingBookTitle"></param>
        /// <param name="incomingBookAuthor"></param>
        /// <param name="incomingBookPages"></param>
        /// <param name="incomingCharacters"></param>
        public Book(string incomingBookTitle, string incomingBookAuthor, int incomingBookPages, List<string> incomingCharacters)
        {
            title = incomingBookTitle;
            author = incomingBookAuthor;
            pages = incomingBookPages;
            characters = incomingCharacters;
        }

        public void AddCharacter(string name)
        {
            characters.Add(name);
        }

        public void RemoveCharacter(string name)
        {
            characters.Remove(name);
        }

        public void ListCharacters()
        {
            foreach (string character in characters)
            {
                Console.WriteLine(character);

            }
        }
    }
}
