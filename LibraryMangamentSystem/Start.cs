using System;
using System.Linq;
namespace LibraryMangamentSystem {
    class Start
    {
        static void Main(string[] args)
        {
            Library library = new Library();



            while (true)
            {
                Console.Clear();
                Console.WriteLine("Are you a Librarian or a Library User? (Enter L for Librarian, U for Library User, or Esc to exit)");
                var key = Console.ReadKey().Key;
                Console.WriteLine();
                if (key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (key == ConsoleKey.L)
                {
                    Console.WriteLine(" hi admin john, Enter Employee ID ");
                    int id = Convert.ToInt16(Console.ReadLine());
                    if (id != 057)
                    {
                        Console.WriteLine(" wrong ID your out ! ");
                        break;
                    }
                    else {
                        Librarian librarian = new Librarian("John", 057);
                        HandleLibrarianActions(librarian, library);
                    }
                    
                }
                else if (key == ConsoleKey.U)
                {
                    LibraryCard card = new LibraryCard(125,2025);
                    LibraryUser user = new LibraryUser("Alice", card);
                    Console.WriteLine(" Welcome Alice! enjoy reading!");
                    HandleUserActions(user, library);
                }
            }
        }

        static void HandleLibrarianActions(Librarian librarian, Library library)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Librarian Actions:");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Add a book");
                Console.WriteLine("3. Delete a book");
                Console.WriteLine("4. Go back to the main menu");

                var choice = Console.ReadLine();
                if (choice == "4") break;

                switch (choice)
                {
                    case "1":
                        librarian.Display(library);
                        break;
                    case "2":
                        AddBook(librarian, library);
                        break;
                    case "3":
                        DeleteBook(librarian, library);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void HandleUserActions(LibraryUser user, Library library)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Library User Actions:");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Go back to the main menu");

                var choice = Console.ReadLine();
                if (choice == "3") break;

                switch (choice)
                {
                    case "1":
                        user.Display(library);
                        break;
                    case "2":
                        BorrowBook(user, library);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void AddBook(Librarian librarian, Library library)
        {
            Console.Clear();
            Console.WriteLine("Enter book details:");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Release Year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            Book newBook = new Book(title, author, category, releaseYear);
            librarian.AddBook(newBook, library);
        }

        static void DeleteBook(Librarian librarian, Library library)
        {
            Console.Clear();
            Console.WriteLine("Enter the title of the book to delete:");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            librarian.RemoveBook(title, library);
       
        }

        static void BorrowBook(LibraryUser user, Library library)
        {
            Console.Clear();
            Console.WriteLine("Enter the title of the book to borrow:");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            user.BorrowBook(library, title);
        }
    }


}
