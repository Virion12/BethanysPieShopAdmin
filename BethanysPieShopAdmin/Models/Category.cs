namespace BethanysPieShopAdmin.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
        public ICollection<Pie>? Pies { get; set; }

    }
}
