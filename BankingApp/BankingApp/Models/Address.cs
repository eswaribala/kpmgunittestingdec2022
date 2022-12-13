using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Address
    {
        [Required, RegularExpression("[A-Za-z0-9]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Door No Should be between 1 and 5 characters")]
        public string? DoorNo { get; set; }
        [Required, RegularExpression("[A-Za-z0-9]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Street Name Should be between 5 and 100 characters")]
        public string? StreetName { get; set; }
        [Required, RegularExpression("[A-Za-z]+", ErrorMessage = "Pattern Not Matching")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "City Should be between 3 and 100 characters")]

        public string? City { get; set; }

    }
}
