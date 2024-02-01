using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        class Book
        {
            public string Title;
            public string Author;
        }

        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "Harry Potter";
            myBook.Author = "J. K. Rowling";

            Console.WriteLine("Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadLine();
        }
    }
}
