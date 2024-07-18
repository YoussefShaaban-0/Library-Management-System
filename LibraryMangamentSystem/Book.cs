using System;

namespace LibraryMangamentSystem
{
    class Book
    {
        public String Title { get; set; }
        
        public String Author { get; set; }
        public String Category { get; set; }

        public int RelaseYear { get; set; }

        public Book(string title, string author, string category, int relaseYear)
        {
            Title = title;
            Author = author;
            Category = category;
            RelaseYear = relaseYear;
        }
    }
}
