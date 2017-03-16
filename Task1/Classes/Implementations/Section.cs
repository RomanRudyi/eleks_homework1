using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes.Definitions;

namespace Task1.Classes
{
    class Section : BaseSection
    {
        public Section() : base() { }

        public Section(string type, Author[] authors) : base(type, authors) { }

        public override int CompareTo(BaseSection section)
        {
            if (this.GetBooksCount() > section.GetBooksCount())
            {
                return 1;
            }
            else if (this.GetBooksCount() < section.GetBooksCount())
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
