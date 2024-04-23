
using System.ComponentModel.DataAnnotations;

namespace Migrations.Entities
{
    internal class Library
    {
        [Key] public int ID { get; set; }
        [Required] public string Name { get; set; }
        public List<Book>Books { get; set; }

    }
}
