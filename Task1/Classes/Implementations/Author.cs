using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes.Definitions;

namespace Task1.Classes
{
    class Author : BaseAuthor
    {
        public Author() : base() { }

        public Author(string name, Book[] books) : base(name, books) { }

        public override int CompareTo(BaseAuthor author)
        {
            if (this.GetBooksCount() > author.GetBooksCount())
            {
                return 1;
            }
            else if (this.GetBooksCount() < author.GetBooksCount())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
