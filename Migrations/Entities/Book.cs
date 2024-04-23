
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migrations.Entities
{
    internal class Book
    {
        [Key] public int ID { get; set; }
        [Required] public string Name { get; set; }
        [Required] public decimal Price { get; set; }
        [ForeignKey(nameof(Library))] public int LibraryID { get; set; }
    }
}
