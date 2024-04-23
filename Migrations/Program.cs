using Microsoft.EntityFrameworkCore;
using Migrations.DAL;
using Migrations.Services;

namespace Migrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Library
            //Create Library
            LibraryService ls = new();
            ls.Add(new() { Name = "Axundov Kitabxanasi" });
            ls.Add(new() { Name = "Azerbaycan Milli Kitabxanasi" });
            ls.Add(new() { Name = "Merkezi Sheher Kitabxanasi" });
            ls.Add(new() { Name = "Respublika Elmi-Texniki Kitabxanasi" });

            //Read Library
            using var dc = new AppDbContext();
            var libraries = dc.Libraries.Include(l => l.BookList).ToList();
            foreach (var library in libraries)
            {
                Console.WriteLine($"Library Name: {library.Name}");
                foreach (var book in library.BookList) Console.WriteLine($"Book Name: {book.Name}");
            }

            //Update Library
            ls.Update("Respublika Elmi-Texniki Kitabxanasi", "Respublika Kitabxanasi");

            //Delete Library
            ls.Add(new() { Name = "TestLibrary" });
            ls.Delete(6);
            #endregion

            #region Books
            //Create Book
            BookService bs = new();
            bs.Add(new() { Name = "1984", Price = 19, LibraryID = 1 });
            bs.Add(new() { Name = "Kimyager", Price = 17, LibraryID = 1 });
            bs.Add(new() { Name = "Herb ve Sulh", Price = 16, LibraryID = 2 });
            bs.Add(new() { Name = "Anna Karenina", Price = 18, LibraryID = 2 });
            bs.Add(new() { Name = "Cinayet ve Ceza", Price = 16, LibraryID = 3 });

            //Read Book
            foreach (var book in bs.GetAll())
            {
                Console.WriteLine($"Book Name: {book.Name}");
            }

            //Update Book
            bs.Update(5, 15);
            #endregion
        }
    }
}
