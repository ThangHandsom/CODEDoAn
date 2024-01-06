using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLTWeb2.Models
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        [Key]
        public int CateProductID { get; set; }
        public string? Name { get; set; }
        public  bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
