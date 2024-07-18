using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryMangamentSystem
{
    class Library
    {
        private List<Book> books = new List<Book>();
        private List<Book> bowrroedBooks = new List<Book>();

        public void Display()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
            }
            else
            {
                Console.WriteLine("Books available in the library:");
                foreach (Book b in books)
                {
                    Console.WriteLine(
                        b.Title + "\n"+
                         b.Author + "\n"+
                          b.Category + "\n"+
                           b.RelaseYear + "\n"
                        );
                }
            }
        }
        public void Add(Book newBook) {
            books.Add(newBook);
            Console.WriteLine("Book added successfully.");

        }
        public void Delete(string title) {
            Book bookToDelete= books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            books.Remove(bookToDelete);
            Console.WriteLine("Book deleted successfully.");
        }
        public void Borrow(string title) {
            Book bookToBorrow = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToBorrow != null )
            {
                if (bowrroedBooks.Count >= books.Count)
                {
                    Console.WriteLine(" cant borrow more books ");
                }
                else
                {
                    bowrroedBooks.Add(bookToBorrow);
                    books.Remove(bookToBorrow);
                    Console.WriteLine("Book borrowed successfully.");

                }
            }
            else {
                Console.WriteLine("Sorry! This book no longer exists in our library.");
            }

        }

    }
}
