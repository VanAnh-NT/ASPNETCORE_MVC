using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using lab6CF.Models;

namespace lab6CF.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public string BoooId { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }
        public Category Category { get; set; }
        public Publisher Publisher { get; set; }

        
    }
}
