using Migrations.DAL;
using Migrations.Entities;

namespace Migrations.Services
{
    internal class BookService
    {
        public void Add(Book book) //Create
        {
            using var dc = new AppDbContext();
            var exists = dc.Books.FirstOrDefault(b => b.Name.Equals(book.Name));
            if (exists != null) return;
            dc.Books.Add(book);
            dc.SaveChanges();
        }
        public List<Book> GetAll() //Read
        {
            using var dc = new AppDbContext();
            return dc.Books.ToList();
        }
        public Book GetById(int id) //Read
        {
            using var dc = new AppDbContext();
            return dc.Books.FirstOrDefault(b => b.ID == id);
        }
        public void Update(int id, decimal newPrice) //Update
        {
            using var dc = new AppDbContext();
            var exists = dc.Books.FirstOrDefault(b => b.ID==id);
            if (exists != null) exists.Price = newPrice;
            dc.SaveChanges();
        }
        public void Delete(int id) //Delete
        {
            using var dc = new AppDbContext();
            var exists = dc.Books.FirstOrDefault(b => b.ID == id);
            if (exists != null) dc.Books.Remove(exists);
            dc.SaveChanges();
        }
    }
}
