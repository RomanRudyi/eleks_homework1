using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    abstract class BaseBook : IComparable<BaseBook>
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public BaseBook() : this("unknown book", 0) { }

        public BaseBook(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

        public abstract int CompareTo(BaseBook book);

        public override string ToString() => ($"\"{Title}\" with {Pages} pages");
    }

    class Book : BaseBook
    {
        public Book() : base() { }

        public Book(string title, int pages) : base(title, pages) { }

        public override int CompareTo(BaseBook book)
        {
            if (this.Pages > book.Pages)
                return 1;
            else if (this.Pages < book.Pages)
                return -1;
            else
                return 0;
        }
    }
}
