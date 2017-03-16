using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes.Definitions;

namespace Task1.Classes
{   
    class Library : BaseLibrary
    {
        public Library() : base() { }

        public Library(Section[] sections) : base(sections) { }

        public override int CompareTo(BaseLibrary library)
        {
            if (this.GetBooksCount() > library.GetBooksCount())
            {
                return 1;
            }
            else if (this.GetBooksCount() < library.GetBooksCount())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        // Additional tasks

        public void ShowBiggestSection()
        {
            Section biggestSection = Sections[0];
            foreach (Section s in Sections)
            {
                if (s.GetBooksCount() > biggestSection.GetBooksCount())
                {
                    biggestSection = s;
                }
            }

            Console.Write($"The biggest section is {biggestSection.Type}: {biggestSection.GetBooksCount()} books\n");
        }

        public void ShowHardworkingAuthor()
        {
            Author hardworkingAuthor = Sections[0].Authors[0];
            foreach (Section s in Sections)
            {
                foreach (Author a in s.Authors)
                {
                    if (a.GetBooksCount() > hardworkingAuthor.GetBooksCount())
                    {
                        hardworkingAuthor = a;
                    }
                }
            }

            Console.Write($"The hardworking author is {hardworkingAuthor.Name}: {hardworkingAuthor.GetBooksCount()} books\n");
        }

        public void ShowThinnestBook()
        {
            Book thinnestBook = Sections[0].Authors[0].Books[0];
            foreach (Section s in Sections)
            {
                foreach (Author a in s.Authors)
                {
                    foreach (Book b in a.Books)
                    {
                        if (b.Pages < thinnestBook.Pages)
                        {
                            thinnestBook = b;
                        }
                    }
                }
            }
            Console.Write($"The thinnest book is {thinnestBook.Title}: {thinnestBook.Pages} pages\n");
        }
    }
}
