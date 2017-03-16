using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes.Definitions;

namespace Task1.Classes
{  
    class Book : BaseBook
    {
        public Book() : base() { }

        public Book(string title, int pages) : base(title, pages) { }

        public override int CompareTo(BaseBook book)
        {
            if (this.Pages > book.Pages)
            {
                return 1;
            }
            else if (this.Pages < book.Pages)
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
