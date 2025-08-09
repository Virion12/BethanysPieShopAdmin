using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopAdmin.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }

        public OrderStatus OrderStatus { get; set; }

        [Required(ErrorMessage = "Please provide your name to proceed with the order")]
        [Display(Name = "First Name")]
        [Length(3, 50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your last name to proceed with the order")]
        [Display(Name = "Last Name")]
        [Length(3, 50)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your Address to proceed with the order")]
        [Display(Name = "Address Line 1")]
        [Length(3, 50)]
        public string AddressLine1 { get; set; } = string.Empty;

        [Display(Name = "AddressLine2")]
        public string? AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please provide your ZipCode to proceed with the order")]
        [Display(Name = "Zip Code")]
        [Length(3, 50)]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your City to proceed with the order")]
        [Display(Name = "city")]
        public string City { get; set; } = string.Empty;

        [Length(3, 100)]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please provide your Country to proceed with the order")]
        [Display(Name = "Country")]
        [Length(3, 100)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your PhoneNumber to proceed with the order")]
        [Length(9, 100)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your email address to proceed with the order")]
        [Length(6, 100)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "the email is not provided in correct format")]
        public string Email { get; set; } = string.Empty;

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
