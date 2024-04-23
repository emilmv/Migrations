using Migrations.DAL;
using Migrations.Entities;

namespace Migrations.Services
{
    internal class LibraryService
    {
        public void Add(Library library) //Create
        {
            using var dc = new AppDbContext();
            var exists = dc.Libraries.FirstOrDefault(l => l.Name.Equals(library.Name));
            if (exists != null) return;
            dc.Libraries.Add(library);
            dc.SaveChanges();
        }
        public List<Library> GetAll() //Read
        {
            using var dc = new AppDbContext();
            return dc.Libraries.ToList();
        }
        public Library GetById(int id) //Read
        {
            using var dc = new AppDbContext();
            return dc.Libraries.FirstOrDefault(l => l.ID == id);
        }
        public void Update(string previousName, string newName) //Update
        {
            using var dc = new AppDbContext();
            var exists = dc.Libraries.FirstOrDefault(l => l.Name.Equals(previousName));
            if (exists != null) exists.Name = newName;
            dc.SaveChanges();
        }
        public void Delete(int id) //Delete
        {
            using var dc = new AppDbContext();
            var exists = dc.Libraries.FirstOrDefault(l => l.ID == id);
            if (exists != null) dc.Libraries.Remove(exists);
            dc.SaveChanges();
        }
    }
}
