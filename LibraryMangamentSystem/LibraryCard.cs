using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMangamentSystem
{
    class LibraryCard
    {
        public int Id { get; set; }
        public int ExpireYear { get; set; }

        public LibraryCard(int id, int expireYear)
        {
            Id = id;
            ExpireYear = expireYear;
        }
    }
}
