using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMangamentSystem
{
    abstract class User
    {
        public string Name { get; set; }
        public abstract void Display(Library library);

    }
}
