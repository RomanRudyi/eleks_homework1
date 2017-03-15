using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    abstract class BaseAuthor : IComparable<BaseAuthor>, ICountingBooks
    {
        private string name;
        private Book[] books;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Book[] Books
        {
            get { return books; }
            set { books = value; }
        }

        public BaseAuthor() : this("unknown author", new Book[] { }) { }

        public BaseAuthor(string name, Book[] books)
        {
            this.name = name;
            this.books = books;
        }

        public abstract int CompareTo(BaseAuthor author);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} has written {Books.Length} books\n");

            var sortedBooks = Books.ToList<Book>();
            sortedBooks.Sort();

            foreach (Book b in sortedBooks)
                builder.Append($"{b}\n");
            return builder.ToString();
        }

        public int GetBooksCount() => (Books.Length);
    }

    class Author : BaseAuthor
    {
        public Author() : base() { }

        public Author(string name, Book[] books) : base(name, books) { }

        public override int CompareTo(BaseAuthor author)
        {
            if (this.GetBooksCount() > author.GetBooksCount())
                return 1;
            else if (this.GetBooksCount() < author.GetBooksCount())
                return -1;
            else
                return 0;
        }
    }
}
