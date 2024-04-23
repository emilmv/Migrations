
using System.ComponentModel.DataAnnotations;

namespace Migrations.Entities
{
    internal class Library
    {
        [Key] public int ID { get; set; }
        [Required][StringLength(255)] public string ?Name { get; set; }
        public List<Book> ?BookList { get; set; }
    }
}
