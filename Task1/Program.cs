using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author stehpenKing = new Author("Stephen King", new Book[]
            {
                new Book("11/22/63", 894),
                new Book("It", 1340),
                new Book("Joyland", 317),
                new Book("Revival", 413)
            });

            Author maxKidruk = new Author("Max Kidruk", new Book[]
            {
                new Book("Bot", 434),
                new Book("Stronghold", 390)
            });

            Section thrillers = new Section("Thillers", new Author[]
            {
                stehpenKing,
                maxKidruk
            });

            Author jeffSutherland = new Author("Jeff Sutherland", new Book[]
            {
                new Book("Scrum", 278)
            });

            Author jeffreyRichter = new Author("Jeffrey Richter", new Book[]
            {
                new Book("CLR via C#", 895)
            });

            Author steveMcConnell = new Author("Steve McConnell", new Book[]
            {
                new Book("Code complete", 880)
            });

            Section education = new Section("Education", new Author[]
            {
                jeffSutherland,
                jeffreyRichter,
                steveMcConnell
            });

            Library library = new Library(new Section[]
            {
                thrillers,
                education
            });

            Console.Write(library);
            
            library.ShowBiggestSection();
            library.ShowHardworkingAuthor();
            library.ShowThinnestBook();

            Console.Read();
        }
    }
}
