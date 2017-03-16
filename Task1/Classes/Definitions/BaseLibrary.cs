using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes.Definitions
{
    abstract class BaseLibrary : IComparable<BaseLibrary>, ICountingBooks
    {
        private Section[] sections;

        public Section[] Sections
        {
            get
            {
                if (sections == null)
                {
                    sections = new Section[] { };
                }
                return sections;
            }
            set { sections = value; }
        }

        public BaseLibrary() : this(null) { }

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
            {
                builder.Append($"{s}\n");
            }
            return builder.ToString();
        }

        public int GetBooksCount()
        {
            int booksCount = 0;
            foreach (Section s in sections)
            {
                booksCount += s.GetBooksCount();
            }
            return booksCount;
        }
    }
}
