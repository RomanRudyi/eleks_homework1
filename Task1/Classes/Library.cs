using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    abstract class BaseLibrary : IComparable<BaseLibrary>, ICountingBooks
    {
        private Section[] sections;

        public Section[] Sections
        {
            get { return sections; }
            set { sections = value; }
        }

        public BaseLibrary() : this(new Section[] { }) { }

        public BaseLibrary(Section[] sections)
        {
            this.sections = sections;
        }

        public abstract int CompareTo(BaseLibrary library);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"The library has {GetBooksCount()} books total\n\n");

            var sortedSections = Sections.ToList<Section>();
            sortedSections.Sort();

            foreach (Section s in sortedSections)
                builder.Append($"{s}\n");
            return builder.ToString();
        }

        public int GetBooksCount()
        {
            int booksCount = 0;
            foreach (Section s in sections)
                booksCount += s.GetBooksCount();
            return booksCount;
        }
    }

    class Library : BaseLibrary
    {
        public Library() : base() { }

        public Library(Section[] sections) : base(sections) { }

        public override int CompareTo(BaseLibrary library)
        {
            if (this.GetBooksCount() > library.GetBooksCount())
                return 1;
            else if (this.GetBooksCount() < library.GetBooksCount())
                return -1;
            else
                return 0;
        }

        // Additional tasks

        public void ShowBiggestSection()
        {
            Section biggestSection = Sections[0];
            foreach (Section s in Sections)
                if (s.GetBooksCount() > biggestSection.GetBooksCount())
                    biggestSection = s;

            Console.Write($"The biggest section is {biggestSection.Type}\n");
        }

        public void ShowHardworkingAuthor()
        {
            Author hardworkingAuthor = Sections[0].Authors[0];
            foreach (Section s in Sections)
                foreach (Author a in s.Authors)
                    if (a.GetBooksCount() > hardworkingAuthor.GetBooksCount())
                        hardworkingAuthor = a;

            Console.Write($"The hardworking author is {hardworkingAuthor.Name}\n");
        }

        public void ShowThinnestBook()
        {
            Book thinnestBook = Sections[0].Authors[0].Books[0];
            foreach (Section s in Sections)
                foreach (Author a in s.Authors)
                    foreach (Book b in a.Books)
                        if (b.Pages < thinnestBook.Pages)
                            thinnestBook = b;

            Console.Write($"The thinnest book is {thinnestBook.Title}\n");
        }
    }
}
