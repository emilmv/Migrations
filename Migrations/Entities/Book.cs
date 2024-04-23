
using System.ComponentModel.DataAnnotations;

namespace Migrations.Entities
{
    internal class Book
    {
        [Key] public int ID { get; set; }
        [Required] public string Name { get; set; }
        [Required] public decimal Price { get; set; }
    }
}
