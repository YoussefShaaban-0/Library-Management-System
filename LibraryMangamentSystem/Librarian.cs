using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMangamentSystem
{
    class Librarian: User
    {
        private int EmplyeeId { get; set; }

        public Librarian(string name,int emplyeeId)
        {
            Name = name;
            EmplyeeId = emplyeeId;
        }

        public void AddBook(Book book,Library lib) 
        {

            lib.Add(book);
        }

        public void RemoveBook(string title ,Library lib)
        {
            lib.Delete(title);
        }
        public override void Display(Library library)
        {
            library.Display();
        }

    }
}
