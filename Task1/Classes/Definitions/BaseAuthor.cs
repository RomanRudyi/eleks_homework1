using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes.Definitions
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
            get
            {
                if (books == null)
                {
                    books = new Book[] { };
                }
                return books;
            }
            set { books = value; }
        }

        public BaseAuthor() : this("unknown author", null) { }

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
            {
                builder.Append($"{b}\n");
            }
            return builder.ToString();
        }

        public int GetBooksCount() => (Books.Length);
    }
}
