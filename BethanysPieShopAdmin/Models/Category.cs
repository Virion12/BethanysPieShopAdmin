using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopAdmin.Models
{
    public class Category
    {

        
        public int CategoryId { get; set; }


        [Length(5,100)]
        [Required]
        public string CategoryName { get; set; } = string.Empty;

        [Length(5, 1000)]
        [Required]
        public string? Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? DateAdded { get; set; }
        public ICollection<Pie>? Pies { get; set; }

    }
}
