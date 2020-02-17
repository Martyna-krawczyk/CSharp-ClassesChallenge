# CSharp-ClassesChallenge

Challenge 4-1 - Shelf Starter<br/>
Create a new class within your Program.cs file named Shelf
Create a new public static property on the Shelf class that is a int named numberOfBooks
Create a new public static method on the Shelf class called AddBook
Takes no parameters
Returns nothing
Body of the method increments numberOfBooks property by 1
 Print the console the numberOfBooks property in the Main() method
Add Two books using the AddBook method
Print the console the numberOfBooks property in the Main() method
 

Challenge 4-2 - Shelf in a Library<br/>
 Move your Shelf class into another file and make sure everything still works

Change the namespace in the new file with your Shelf class to Library

Update your Project.cs file so that everything is working again with the new namespace (no compile errors).

 

Challenge 4-3 - Your New Book!<br/>
 Create a new file and define a Book class
 Create a constructor on the Book class which has 3 parameters
title (string)
author (string)
pages (int)
Create 3 public instance properties of the same name in the class<br/>
Save the values from the parameters in the constructor to the properties on the class
 Create a new private property named characters on the Book class which is a List that can hold strings
Create a new public method on the Book class named AddCharacter
Takes 1 parameter which is a string and named name
Returns no value
Body of the method takes the character variable and adds it to the List held by the characters property
 Create a new public method on the Book class named RemoveCharacter
Takes 1 parameter which is a string named name
Returns no value
Body of the method will take that string use it to remove the same string from the List held by the characters property
 Create a override for the constructor that has a 4th parameter named characters
This new parameter is a List of strings
Use the characters parameter to set the characters property on the class
 *Advanced - use the original constructor in your override to help keep your code DRY
 Create a new public method on the book class named ListCharacters
 Takes no parameters
 Returns no value
Body of the method will print out each character name from the characters property using a foreach loop
In your Program.cs file create two new instances of Book.
First one using the 3 parameter constructor
Add a couple new characters using the AddCharacter method
Second one using the 4 parameter constructor and passing in a List of characters.<br/>

Challenge 4-4 - Putting Books On A Shelf<br/>
 Create a new private property on Shelf named books that will hold a List of Book
Create a new public static method on Shelf named AddBook
Has 1 parameter which is a Book named book
Returns no value
Body of the method adds a book to the books property
Create a new public static method on Shelf named ListBooks
Has no parameters
Returns no value
Body of the method loops through the books property using a for loop
Inside of the loop print out to the console the title of each book
In Programs.cs use the AddBook method to add your two books to Shelf
In Program.cs call the ListBooks method (you should see your book titles printed to the console)
 

Challenge 4-5 - Counting Books<br/>
In Shelf remove the default value of 0 from numberOfBooks

Remove the incrementor from the AddBook() method.
Instead create a getter that returns the count from the books property

Do not define a setter

In Program.cs Console.WriteLine() the numberOfBooks property from Shelf. You should see the number 2 printed.
 

Challenge 4-6 - Searching For A Book<br/>
On the Shelf class create a new public static method named HasBook

Has one parameter that is a string named title
Returns a boolean
The body of the method uses the title to check if the book currently exists in List held by the books property
On the Shelf class create a new public static method named GetBookAuthor
Has 1 parameter that is a string named title
Returns a string (author)
The body of the method will first use the HasBook method to determine if the books exists
If the book does not exist return an empty string
If the book does exist return the author from the book
 
