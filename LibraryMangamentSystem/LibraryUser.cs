using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMangamentSystem
{
    class LibraryUser: User
    {
        public LibraryCard Card { get; set; }

        public LibraryUser(String name , LibraryCard card) {
            Name = name;
            Card = card;
        }

        public override void Display(Library library)
        {
            library.Display();
        }

        public void BorrowBook(Library library, string title)
        {
            library.Borrow(title);
        }
    }
}
