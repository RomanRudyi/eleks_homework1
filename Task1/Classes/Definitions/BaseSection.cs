using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes.Definitions
{
    abstract class BaseSection : IComparable<BaseSection>, ICountingBooks
    {
        private string type;
        private Author[] authors;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Author[] Authors
        {
            get
            {
                if (authors == null)
                {
                    authors = new Author[] { };
                }
                return authors;
            }
            set { authors = value; }
        }

        public BaseSection() : this("unknown section", null) { }

        public BaseSection(string type, Author[] authors)
        {
            this.type = type;
            this.authors = authors;
        }

        public abstract int CompareTo(BaseSection section);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"The \"{Type}\" section has {GetBooksCount()} books total\n\n");

            var sortedAuthors = Authors.ToList<Author>();
            sortedAuthors.Sort();

            foreach (Author a in sortedAuthors)
                builder.Append($"{a}\n");
            return builder.ToString();
        }

        public int GetBooksCount()
        {
            int booksCount = 0;
            foreach (Author a in authors)
                booksCount += a.GetBooksCount();
            return booksCount;
        }
    }
}
