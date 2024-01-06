using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLTWeb2.Models
{
    [Table("Booking")]
    public class Booking
    {
        [Key] 
        public int OrderID { get; set; }
        public string? CusName { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? NumberOfPeople { get; set; }
        public string? SpecialRequest { get; set; }
    }
}
