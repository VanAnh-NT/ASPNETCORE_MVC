using System.ComponentModel.DataAnnotations.Schema;

namespace lab07CF.Models
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }    
        public bool Status { get; set; }    
        public DateTime CreateTime { get; set; }    
        public string Image{ get; set; }    
        public string Description{ get; set; }    
        ICollection<Product> Products { get; set; }

    }
}
