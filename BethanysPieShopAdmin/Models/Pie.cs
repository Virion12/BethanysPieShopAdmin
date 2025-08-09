using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopAdmin.Models
{
    public class Pie
    {
        public int PieId { get; set; }

        [Display(Name =" Name")]
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Length(0, 100)]
        public string? ShortDescription { get; set; }
        
        [Length(0, 1000)]
        public string? LongDescription { get; set; }
        [Length(0,1000)]
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public ICollection<Ingredient>? Ingredients { get; set; }
    }
}
