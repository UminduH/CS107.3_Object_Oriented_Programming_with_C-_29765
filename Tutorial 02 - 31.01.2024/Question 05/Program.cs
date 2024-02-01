using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question_05
{
    internal class Program
    {
        class LibraryBook
        {
            public string Title;
            public string Author;
            public bool Available;

            public LibraryBook(string title, string author, bool available)
            {
                Title = title;
                Author = author;
                Available = available;
            }

            public void BorrowBook()
            {
                if (Available)
                {
                    Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
                    Available = false;
                }
                else
                {
                    Console.WriteLine($"Sorry, the book '{Title}' is currently unavailable.");
                }
            }
        }

        static void DisplayLibraryStatus(LibraryBook book)
        {
            Console.WriteLine($"Book: '{book.Title}' by {book.Author}");
            Console.WriteLine($"Available: {book.Available}\n");
        }

        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", true);
            LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", false);
            LibraryBook book3 = new LibraryBook("The Adventures of Sherlock Holmes", "Arthur Conan Doyle", true);

            Console.WriteLine("INITIAL LIBRARY STATUS:\n");
            DisplayLibraryStatus(book1);
            DisplayLibraryStatus(book2);
            DisplayLibraryStatus(book3);

            Console.WriteLine("\nBORROWING BOOKS:\n");
            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();

            Console.WriteLine("\nUPDATED LIBRARY STATUS:\n");
            DisplayLibraryStatus(book1);
            DisplayLibraryStatus(book2);
            DisplayLibraryStatus(book3);

            Console.ReadLine();
        }
    }
}
